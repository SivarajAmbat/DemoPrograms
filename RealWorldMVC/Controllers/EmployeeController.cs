using RealWorldMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealWorldMVC.Controllers
{
	public class EmployeeController : Controller
	{
		//
		// GET: /Employee/
		public ActionResult Index()
		{
			return View();
		}


		public ActionResult Browse()
		{

			var employee = new Employee
			{
				ID = 1,
				FirstName = "Jane",
				LastName = "Dove"
			};

			TempData["employee"] = employee;

			return RedirectToAction("Index");
		}

        public ActionResult GetEmployee()
        {
            var employee = new Employee { ID = 7, FirstName = "James", LastName = "Bond" };

            return View(employee);
        }
	}
}
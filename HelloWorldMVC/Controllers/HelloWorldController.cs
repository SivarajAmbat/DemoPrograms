using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public string SayHello() // www.localhost:1234/HelloWorld/SayHello
        { 
            return "Hello World from MVC at " + DateTime.Now.ToLongTimeString();
        }

        public string Index() // www.localhost:1234/HelloWorld
        {
            return "Hello World (index) from MVC at " + DateTime.Now.ToLongTimeString();
        }
	}
}
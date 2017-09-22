using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MemoryCachingDemo
{
    class CachingDemo
    {
        static void Main(string[] args)
        {
            Employees emp = new Employees();

            while (true)
            {
                var results = emp.GetEmployees();
                foreach (var item in results)
                {
                    Console.WriteLine(item);
                }
                Thread.Sleep(2000);
                Console.WriteLine("Press any key to repeat; X to exit");
                if (Console.ReadKey().Key.Equals(ConsoleKey.X))
                    break;
            }
        }
    }

    class Employees
    {
        private const string cacheKey = "employees";

        public IEnumerable<string> GetEmployees()
        {
            var cache = MemoryCache.Default;

            List<string> filepaths = new List<string>();
            filepaths.Add(@"C:\temp\data.txt");

            if (!cache.Contains(cacheKey))
            {
                Console.WriteLine("--- Setting up the cache --- ");

                CacheItemPolicy policy = new CacheItemPolicy();
                policy.ChangeMonitors.Add(new HostFileChangeMonitor(filepaths));
                policy.AbsoluteExpiration = DateTime.Now.AddSeconds(50.0);

                //cache.Set(cacheKey, GetNames(), policy);

                cache.Set(cacheKey, GetFromFile(), policy);
            }

            Console.WriteLine("--- Reading from cache ---");
            return cache.Get("employees") as List<string>;
        }

        private static IEnumerable<string> GetNames()
        {
            return new List<String> { "Jack", "Tom", "Bob" };
        }

        private static IEnumerable<string> GetFromFile()
        {
            return new List<string> { File.ReadAllText(@"C:\temp\data.txt") };
        }

    }
}

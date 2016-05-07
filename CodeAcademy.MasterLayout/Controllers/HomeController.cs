using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeAcademy.MasterLayout.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            List <string>numbers = new List<string>();
            numbers.Add("1111");
            numbers.Add("2222");

            return View(numbers);
        }

        public ActionResult Messages()
        {
            List<string> messages = new List<string>();
            messages.Add("It is fun writing C# and Razor code alon with ASP.NET MVC");
            messages.Add("ASP.NET MVC is the best web framework I've ever been working with");
            messages.Add("Well known public secret: Chuck Norris codes in ASP.NET MVC");
            messages.Add("We are web developers");
            messages.Add("You can ship ASP.NET in your Fridge! Today!");

            return View(messages);
        }

        public ActionResult Exercise()
        {
            List<string> Test = new List<string>();

            Test.Add("aaaaa");
            Test.Add("aaaaa");
            Test.Add("aaaaa");
            Test.Add("aaaaa");
            Test.Add("aaaaa");
            Test.Add("aaaaa");
            Test.Add("aaaaa");
            Test.Add("aaaaa");
            Test.Add("aaaaa");
            Test.Add("aaaaa");

            
            return View(Test);

            
        }
    }
}
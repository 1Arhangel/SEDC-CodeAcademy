using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeAcademy.EmployeeManagement.WebApp.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(string name, string surname, string jobposition)
        {
            ViewBag.Name = name;
            ViewBag.Surname = surname;
            ViewBag.JobPosition = jobposition;
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }
        
        //employees/delete/(int id)
        [HttpPost]
        public bool Delete(int id)
        {
            return false;
        }
    }
}
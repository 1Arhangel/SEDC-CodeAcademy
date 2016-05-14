using CodeAcademy.MVCModels.v2._0.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeAcademy.MVCModels.v2._0.WebApp.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        Database db = new Database();
        // GET: Customers
        public ActionResult Index()
        {
            var customers = db.Customers.ToList();
            return View(customers);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int ID)
        {
            var dbCustomer = db.Customers.FirstOrDefault(x => x.ID == ID);
            return View(dbCustomer);
        }

        [HttpPost]
        public ActionResult Delete(Customer customer)
        {
            if(customer != null && customer.ID > 0)
            {
                var dbCustomer = db.Customers.FirstOrDefault(x => x.ID == customer.ID);
                db.Customers.Remove(dbCustomer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
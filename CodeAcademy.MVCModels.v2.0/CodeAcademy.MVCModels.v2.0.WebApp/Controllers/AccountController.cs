using CodeAcademy.MVCModels.v2._0.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CodeAcademy.MVCModels.v2._0.WebApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        Database db = new Database();
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)


        {
            var dbCustomer = db.Customers.FirstOrDefault(x => x.Email == email && x.Password == password);
            
            if(dbCustomer != null)
            {
                FormsAuthentication.SetAuthCookie(email, true);
                    return RedirectToAction("Index", "Customer");
            }

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Customer customer)
        {
            if(ModelState.IsValid)
            {
                //do customer registration by saving into the database
                db.Customers.Add(customer);
                db.SaveChanges();

                return RedirectToAction("Login");
            }
            return View();
        }
    }
}
using CodeAcademy.MVCModels.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeAcademy.MVCModels.WebApp.Controllers
{
    public class ProductsController : Controller
    {
        Database db = new Database();
        // GET: Products
        public ActionResult Index(string query)
        {


            

            List<Product> products = db.GetProducts();

            if (!string.IsNullOrEmpty(query))
            {
                query = query.ToLower();
                products = products.Where(x => x.Name.ToLower().Contains(query)).ToList();

            
            }
            return View(products);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                db.AddProduct(product);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Product product = db.GetProducts().FirstOrDefault(x => x.ID == id);

            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            db.DeleteProduct(product);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Search()
        {

            List<Product> products = db.GetProducts();

            return View(products);
        }
        //
    }
}
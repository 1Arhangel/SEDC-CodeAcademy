using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CodeAcademy.MVCModels.WebApp.Models
{
    public class Database
    {
        

        public Database()
        {
            if(HttpContext.Current.Application["Products"] == null)
            HttpContext.Current.Application["Products"]= new List<Product>();
        }

        public List<Product> GetProducts()
        {
            return HttpContext.Current.Application["Products"] as List<Product>;
        }

        public void AddProduct(Product product)
        {
            //get current list of products we have in memory
            List<Product> dbProducts = HttpContext.Current.Application["Products"] as List<Product>;
            //add the new product
            dbProducts.Add(product);
            // return back in memory the new list with the newly added product
            HttpContext.Current.Application["Products"] = dbProducts;
        }

        public void DeleteProduct(Product product)
        {
            List<Product> dbProducts = HttpContext.Current.Application["Products"] as List<Product>;
            //remove 
            Product productToDelete = dbProducts.FirstOrDefault(x => x.ID == product.ID);

            if (productToDelete != null)
            {
                dbProducts.Remove(productToDelete);
            }
            // return back in memory the new list with the newly added product
            HttpContext.Current.Application["Products"] = dbProducts;
        }


    }
}

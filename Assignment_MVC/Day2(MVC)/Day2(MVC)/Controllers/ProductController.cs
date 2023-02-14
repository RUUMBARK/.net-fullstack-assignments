using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day2_MVC_.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Models.Product p = new Models.Product();
            //pass a list of products to the view
            return View(p.GetProduct());
        }
    }
}

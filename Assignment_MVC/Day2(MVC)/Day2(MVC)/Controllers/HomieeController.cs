using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day2_MVC_.Controllers
{
    public class HomieeController : Controller
    {
        public IActionResult Index(string id)
        {
            if (id == null) 
            { 
                return Content("<h1>This is a demo of ContentResult</h1>"); 
            }
            else if(id.ToLower() == "plain")
            { 
                return Content("<h1>This is a demo of ContentResult</h1>", "text/plain"); 
            }
            else if(id.ToLower() == "html")
            {
                return Content("<h1>This is a demo of ContentResult</h1>", "text/html"); 
            }
            else if(id.ToLower() == "xml")
            { 
                return Content("<h1>This is a demo ofContentResult</h1>", "text/xml"); 
            }
            return Content("Invalid content type");
        }

         public ActionResult DownloadFile()
         { 
            if (!System.IO.File.Exists(@"C:\Users\RUUMBARK\Pictures\Screenshots\Screenshot (8).png"))
            { 
                return Content("File to be downloaded not found"); 
            } 
            return PhysicalFile(@"C:\Users\RUUMBARK\Pictures\Screenshots\Screenshot (8).png", "image/jpg", "default.jpg"); 
         }

        public ActionResult Google() 
        { 
            return Redirect("http://www.google.com");
        }

        public ActionResult StartPage() 
        { 
            return RedirectToAction("Index", new { id = "xml" }); 
        }
        public ActionResult Login() 
        { 
            return View();
        }
        public ActionResult AboutUs() 
        {
            return View(); 
        }
    }
}

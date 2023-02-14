using Day4_MVC_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Day4_MVC_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext Context;
        public HomeController(ILogger<HomeController> logger, MyDbContext Context)
        {
            _logger = logger;
            this.Context = Context;
        }

        public IActionResult Index()
        {
            return View(Context.Accounts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult CreateAccount(Account a)
        {
            /*Context.Accounts.Add(a);
            Context.SaveChanges();
            return RedirectToAction("Index");

            if (a.AccountNumber < 0)
            {
                ModelState.AddModelError("AccountNumber", "Account number cannot be negative");
}
            if (string.IsNullOrEmpty(a.Name))
            {
                ModelState.AddModelError("Name", "Account holder's name is required");
            }
            if ((a.CurrentBalance >= 1 && a.CurrentBalance < 500) ||
                        a.CurrentBalance < 0)
            {
                ModelState.AddModelError("CurrentBalance", "Minimum balance must be atleast 500");
            }*/

            if (ModelState.IsValid)
            {
                Context.Accounts.Add(a);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create");

        }
        public ActionResult Edit(int? accno)
        {
            var account_to_edit = (from a in Context.Accounts
                                   where a.AccountNumber == accno
                                   select a).SingleOrDefault();
            return View(account_to_edit);
        }
        public ActionResult EditAccount(Account a)
        {
            Context.Entry<Account>(a).State = EntityState.Modified;
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? accno)
        {
            var account_to_delete = (from a in Context.Accounts
                                     where a.AccountNumber == accno
                                     select a).SingleOrDefault();
            Context.Entry<Account>(account_to_delete).State =
                    EntityState.Deleted;
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public JsonResult CheckAccountNumber(int AccountNumber)
        {
            var acc = (from a in Context.Accounts
                       where a.AccountNumber == AccountNumber
                       select a).SingleOrDefault();

            if (acc == null)
            {
                return Json(true, new Newtonsoft.Json.JsonSerializerSettings());
            }
            return Json("Account number " + AccountNumber + "already exists", new Newtonsoft.Json.JsonSerializerSettings());
}


    }
}
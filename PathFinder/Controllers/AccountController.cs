using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PathFinder.Models;

namespace PathFinder.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return PartialView("_Registration");
        }

        public ActionResult RegisterUser()
        {
            return View("_Registration");
        }

        [HttpPost]
        public ActionResult RegisterUser(Account model)
        {
            if (ModelState.IsValid)
            {
                return View("~/Views/Home/Index")
            }
            return View("_Registration");
        }

        ActionResult ProcessAccount(string message)
        {
            if (ModelState.IsValid)
            {
                return View("~/Views/Home/Index.cshtml");
            }

            return View("~/Views/Home/Index.cshtml");
        }
    }
}
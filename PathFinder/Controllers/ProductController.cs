using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PathFinder.Models;

namespace PathFinder.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View("Keyboard");
        }

        public ActionResult Accessories()
        {
            return View("Accessories");
        }

        public ActionResult Software()
        {
            return View("Software");
        }

        [HttpGet]
        public ActionResult ProductDescription()
        {
            return PartialView("_ProductDescription");
        }

        [HttpPost]
        public ActionResult ProductDescription(Product model)
        {
            return View("_ProductDescription", model);
        }
    }
}
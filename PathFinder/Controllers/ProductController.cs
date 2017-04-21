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
        [HttpGet]
        public ActionResult Index()
        {
            return View("Keyboard");
        }

        [HttpGet]
        public ActionResult Accessories()
        {
            return View("Accessories");
        }

        [HttpGet]
        public ActionResult Software()
        {
            return View("Software");
        }

        [HttpGet]
        public ActionResult ProductDescription()
        {
            return View("_ProductDescription", new Product());
        }

        [HttpPost]
        public ActionResult ProductDescription(Product model)
        {
            return View("_ProductDescription", model);
        }
    }
}
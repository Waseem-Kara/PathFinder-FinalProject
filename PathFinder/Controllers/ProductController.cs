using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult ProductDescription()
        {
            return View("_ProductDescription");
        }
    }
}
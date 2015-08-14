using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DropdownDemo_BareBones.Models;

namespace DropdownDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This is the index page";

            return View();
        }

        public ActionResult MyView()
        {
            ViewBag.Message = "This is the MyView page";

            TestModel m = new TestModel();
            m.Gender = "Female";
            return View(m);
        }
    }
}

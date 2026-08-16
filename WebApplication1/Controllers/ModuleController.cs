using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ModuleController : Controller
    {
        public ActionResult MainPage()
        {
            return View();
        }
        public ActionResult AboutPage()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FF_BT_SHORP.Web.Controllers.Webs
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "批发宝-App appliction";
            return View();
        }
    }
}
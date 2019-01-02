using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagicConsole.features.Home
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }

        public ActionResult DashBoard()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView("Index");
            }
            return View("Index");
        }

        public ActionResult Urls()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }

        public ActionResult Code()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }

        public ActionResult TimeReport()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }
    }
}
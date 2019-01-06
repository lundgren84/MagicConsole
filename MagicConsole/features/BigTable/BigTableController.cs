using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagicConsole.features.BigTable
{
    public class BigTableController : Controller
    {
        public ActionResult Index()
        {
            var isAjaxRequest = Request.IsAjaxRequest();
            ViewBag.isAjaxRequest = isAjaxRequest;

            if (isAjaxRequest)
            {
                return PartialView();
            }
            return View();
        }
    }
}
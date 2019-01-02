using MagicConsole.features.Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagicConsole.features.Code
{
    public class CodeController : Controller
    {
        public ActionResult Index()
        {
            var model = new CodeViewModel
            {
                 IsAjaxRequest = Request.IsAjaxRequest()
            };

            if (Request.IsAjaxRequest())
            {
                return PartialView(model);
            }
            return View(model);
        }
    }
}
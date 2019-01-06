using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MagicConsole.DbLayer;
using MagicConsole.features.Home.Models;

namespace MagicConsole.features.Home
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var model = GetViewModel();
            var isAjaxRequest = Request.IsAjaxRequest();
            ViewBag.isAjaxRequest = isAjaxRequest;

            if (isAjaxRequest)
            {
                return PartialView("Index", model);
            }
            return View("Index", model);
        }

        public ActionResult DashBoard()
        {
            var model = GetViewModel();
            var isAjaxRequest = Request.IsAjaxRequest();
            ViewBag.isAjaxRequest = isAjaxRequest;

            if (isAjaxRequest)
            {
                return PartialView("Index", model);
            }
            return View("Index", model);
        }

        private HomeViewModel GetViewModel()
        {
            var model = new HomeViewModel();

            using (var ctx = new LundgrenDbContext())
            {
                model.Categories = ctx.Categories.ToList();
            }

            return model;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Senin Hakkında Sayfan.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Senin İletişim Sayfan.";

            return View();
        }

        public ActionResult Bilgi()
        {
            return View();
        }

        public ActionResult Profilim()
        {
            return View();
        }
    }
}
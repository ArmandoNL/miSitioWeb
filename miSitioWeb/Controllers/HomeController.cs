﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace miSitioWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Pasatiempos()
        {
            return View();
        }

        public ActionResult Computación()
        {
            return View();
        }

        public ActionResult Objetivos()
        {
            return View();
        }

        public ActionResult Com_Cursos()
        {
            return View();
        }

        public ActionResult Com_Descargas()
        {
            return View();
        }

        public ActionResult Com_Porqué()
        {
            return View();
        }

        public ActionResult Com_Prof()
        {
            return View();
        }
    }
}
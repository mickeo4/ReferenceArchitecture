﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdventureWorks.CrossCutting;
using AdventureWorks.Domain;
using AdventureWorks.ApplicationServices.GetCustomers;

namespace AdventureWorks.MVC.Controllers
{
    public class HomeController : Controller
    {
        #region Constructor

        public HomeController()
        {
            
        }

        #endregion

        #region Actions

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to kick-start your ASP.NET MVC application.";

            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("Contact");
        }

        #endregion
    }
}

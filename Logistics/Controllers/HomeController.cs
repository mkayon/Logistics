﻿using Logistics.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logistics.Controllers
{
    public class HomeController : ApplicationBaseController
    {
        public ActionResult TransportationOrder()
        {

            TransportationOrderViewModel model = TransportationOrderViewModel.CreateTestViewModel();

            return View(model);
        }
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
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
    }
}
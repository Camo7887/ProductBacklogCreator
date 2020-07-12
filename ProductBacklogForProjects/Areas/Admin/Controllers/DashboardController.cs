﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductBacklogForProjects.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Admin/Dashboard
        [Authorize(Roles ="Admin")]
        public ActionResult Index()
        {
            return View();
        }

    }
}
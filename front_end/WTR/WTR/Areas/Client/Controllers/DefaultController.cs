﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WTR.Areas.Client.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Client/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}
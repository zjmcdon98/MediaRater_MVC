﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaRater_MVC.Controllers
{
    public class MediaController : Controller
    {
        // GET: Media
        public ActionResult Index()
        {
            return View();
        }
    }
}
using MediaRater_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaRater_MVC.Controllers
{
    public class MediaController : Controller
    {
        // Get: Media
        private MediaDBContext db = new MediaDBContext();

        // GET: Media
        public ActionResult Index()
        {
            return View(db.Media.ToList());
        }
    }
}
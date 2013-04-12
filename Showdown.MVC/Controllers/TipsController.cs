using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Showdown.MVC.Controllers
{
    public class TipsController : Controller
    {
        //
        // GET: /Tips/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pastry()
        {
            return View();
        }

        public ActionResult Bread()
        {
            return View();
        }

        public ActionResult Cakes()
        {
            return View();
        }
    }
}

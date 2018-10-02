using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBR1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           

            return View();
        }

        public ActionResult Lekcje()
        {
           

            return View();
        }

        [Authorize(Users = "janeksbr1,mariuszsbr2,tomeksbr3")]
        public ActionResult Trening()
        {
            return View();
        }
    }
}
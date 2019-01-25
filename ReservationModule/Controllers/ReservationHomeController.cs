using Administration.CommunicationModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservationModule.Controllers
{
    public class ReservationHomeController : Controller
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

        public ActionResult ViewTables()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(
            string userEmail,
            int chairsNeeded,
            DateTime date,
            DateTime time)
        {
            CommunicationModule.SaveReservation(userEmail, chairsNeeded, date, time);
            return View();
        }
    }
}
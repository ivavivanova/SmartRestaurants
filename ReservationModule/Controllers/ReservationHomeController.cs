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
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewTables()
        {
            return View(CommunicationModule.GetAllFreeTables());
        }

        [HttpPost]
        public ActionResult Index(
            string userEmail,
            int chairsNeeded,
            DateTime date,
            DateTime time,
            string phoneNum,
            int tableType)
        {
            CommunicationModule.SaveReservation(userEmail, chairsNeeded, date, time, phoneNum, tableType);
            return View();
        }
    }
}
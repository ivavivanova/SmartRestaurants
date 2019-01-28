using Administration.CommunicationModule;
using System.Linq;
using System.Web.Mvc;

namespace TableSelectionModule.Controllers
{
    public class TablesSectionController : Controller
    {
        public ActionResult Index()
        {
            return View(CommunicationModule.GetFreeTableNumbers());
        }

        [HttpPost]
        public ActionResult Index(string userEmail)
        {
            return Json(new { tableNum = CommunicationModule.OccupiedTableByEmail(userEmail) });
        }

        [HttpPost]
        public ActionResult GetTable(string tableNum)
        {
            CommunicationModule.OccupiedTable(tableNum);
            return View("Index", CommunicationModule.GetFreeTableNumbers());
        }
    }
}
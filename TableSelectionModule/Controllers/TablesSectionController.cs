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
        public ActionResult GetTable(string tableNum)
        {
            CommunicationModule.OccupiedTable(tableNum);
            return View("Index", CommunicationModule.GetFreeTableNumbers());
        }
    }
}
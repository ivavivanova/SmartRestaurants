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
    }
}
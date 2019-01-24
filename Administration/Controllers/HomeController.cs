using Administration.ViewModels;
using Infrastructure;
using System.Linq;
using System.Web.Mvc;

namespace Administration.Controllers
{
    public class HomeController : Controller
    {
        public static string UserRole;
        private UnitOfWork unitOfWork = new UnitOfWork();

        [HttpGet]
        public ActionResult Index()
        {
            if (UserRole == null)
            {
                return this.Redirect(Url.Action("Login", "Home"));
            }
            else
            {
                return View(new ReservationsViewModel(unitOfWork.ReservationRepository.GetAll()));
            }
        }

        [HttpGet]
        public ActionResult Tables()
        {
            return View(new TablesViewModel(unitOfWork.TableRepository.GetAll().Where(t => t.StatusId == 2)));
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userRole)
        {
            UserRole = userRole;
            return this.Redirect(Url.Action("Index", "Home"));
        }

        [HttpGet]
        public ActionResult Logout()
        {
            UserRole = null;
            return this.Redirect(Url.Action("Login", "Home"));
        }

        [HttpPost]
        public ActionResult SetFreeTable(int tableId)
        {
            var table = this.unitOfWork.TableRepository.GetByID(tableId);
            table.StatusId = 1;
            this.unitOfWork.Save();

            return this.Redirect(Url.Action("Tables", "Home"));
        }
    }
}
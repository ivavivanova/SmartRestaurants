using Administration.ViewModels;
using Common;
using System.Web.Mvc;

namespace Administration.Controllers
{
    public class HomeController : Controller
    {
        public static string UserRole;
        private UnitOfWork unitOfWork = new UnitOfWork();

        public ActionResult Index()
        {
            if (UserRole == null)
            {
                return this.Redirect(Url.Action("Login", "Home"));
            }
            else
            {
                return View(new ReservationsViewModel());
            }
        }

        public ActionResult Tables()
        {
            return View(new TablesViewModel());
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult Login(string userRole)
        {
            UserRole = userRole;
            return this.Redirect(Url.Action("Index", "Home"));
        }

        [HttpGet]
        public virtual ActionResult Logout()
        {
            UserRole = null;
            return this.Redirect(Url.Action("Login", "Home"));
        }
    }
}
using System.Web.Mvc;

namespace Administration.Controllers
{
    public class HomeController : Controller
    {
        public static string UserId;

        public ActionResult Index()
        {
            if (UserId == null)
            {
                return this.Redirect(Url.Action("Login", "Home"));
            }
            else
            {
                return View();
            }
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult Login(string userId)
        {
            UserId = userId;
            return this.Redirect(Url.Action("Index", "Home"));
        }

        [HttpGet]
        public virtual ActionResult Logout()
        {
            Session.Abandon();

            return new EmptyResult();
        }
    }
}
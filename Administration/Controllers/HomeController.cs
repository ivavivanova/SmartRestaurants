using System.Web.Mvc;

namespace Administration.Controllers
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

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult Login(int userId)
        {
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
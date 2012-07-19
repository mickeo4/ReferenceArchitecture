using System.Web.Mvc;

namespace AdventureWorks.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

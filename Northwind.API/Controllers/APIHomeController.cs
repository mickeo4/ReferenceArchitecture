using System.Web.Mvc;

namespace AdventureWorks.WebAPI.Controllers
{
    public class APIHomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

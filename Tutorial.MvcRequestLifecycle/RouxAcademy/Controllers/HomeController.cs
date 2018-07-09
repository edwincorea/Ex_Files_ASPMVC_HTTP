using System.Web.Mvc;

namespace RouxAcademy.Controllers
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

        public ActionResult Programs()
        {
            return View();
        }

        public ActionResult ProgramDetails(int id)
        {
            return Content("Program Details");
        }

        public ActionResult Spotlight()
        {
            return View();
        }
    }
}
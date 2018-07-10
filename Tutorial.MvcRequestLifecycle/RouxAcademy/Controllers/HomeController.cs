using RouxAcademy.LoggerService;
using RouxAcademy.Models.HomeViewModels;
using System.Web.Mvc;

namespace RouxAcademy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;

        public HomeController() { }

        public HomeController(ILogger logger)
        {
            this._logger = logger;
        }

        public ActionResult Index()
        {
            this._logger.Log("Home Index action");

            return View(); 
        }

        public ActionResult About()
        {
            var logger = DependencyResolver.Current.GetService<ILogger>();
            logger.Log("Home About action");

            return View();
        }

        public ActionResult Programs()
        {
            return View();
        }

        [Route("Academics/Detail/{id:int?}")]
        public ActionResult ProgramDetails(int id)
        {
            return Content("Program Details");
        }

        public ActionResult Spotlight()
        {
            return View();
        }

        [HttpGet]
        [ActionName("Contact")]
        public ActionResult ContactUs()
        {
            return View("ContactUs");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [ActionName("Contact")]
        public ActionResult ContactUs(ContactViewModel contact)
        {
            //TODO: Forward contact info to support team

            return View("ContactUs", contact);
        }
    }
}
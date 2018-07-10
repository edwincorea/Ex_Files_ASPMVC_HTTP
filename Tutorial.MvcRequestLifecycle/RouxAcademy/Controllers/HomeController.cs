﻿using RouxAcademy.LoggerService;
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
    }
}
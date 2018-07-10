using RouxAcademy.Controllers;
using RouxAcademy.LoggerService;
using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace RouxAcademy
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type controllerType = null;
            ILogger logger = new Logger();

            if(controllerName == "Home")
            {
                controllerType = typeof(HomeController);
            }

            // Create controller instance
            IController controller = Activator.CreateInstance(controllerType, logger) as IController;

            return controller;
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            
        }
    }
}
using System;
using System.Diagnostics;
using System.Web;

namespace CustomHttpModule
{
    public class LoggingHttpModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.LogRequest += Application_LogRequest;
        }

        private void Application_LogRequest(object sender, EventArgs e)
        {
            HttpApplication application = sender as HttpApplication;
            HttpContext context = application.Context;

            string requestPath = context.Request.Path;

            Trace.WriteLine(String.Format("Request Path: {0}", requestPath));
        }
    }
}

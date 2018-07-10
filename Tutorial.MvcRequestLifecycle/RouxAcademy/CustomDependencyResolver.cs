using RouxAcademy.LoggerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RouxAcademy
{
    public class CustomDependencyResolver : IDependencyResolver
    {
        public object GetService(Type serviceType)
        {
            // Real Wold Use Case: delegate on a DI container which provide registered service
            if (serviceType == typeof(ILogger))
            {
                return new Logger();
            }

            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Enumerable.Empty<object>();
        }
    }
}
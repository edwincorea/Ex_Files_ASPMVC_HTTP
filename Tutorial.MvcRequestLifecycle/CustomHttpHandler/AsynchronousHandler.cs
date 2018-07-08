using System.Threading.Tasks;
using System.Web;

namespace CustomHttpHandler
{
    public class AsynchronousHandler : HttpTaskAsyncHandler
    {
        public override Task ProcessRequestAsync(HttpContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}

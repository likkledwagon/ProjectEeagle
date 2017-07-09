using System.Web;

namespace Eagle.Http
{
    public class EegleHttpContextWrapper
    {
        public EegleHttpContextWrapper(HttpContext httpContext)
        {
            HttpContext = httpContext;
        }

        public HttpContext HttpContext { get; }
    }
}

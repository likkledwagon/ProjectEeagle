using System.Web.Http;
using Eagle.Web.Filters;
using Eagle.Web.Helpers;
using Eagle.Web.Models;
using Eagle.Services.Interfaces;

namespace Eagle.Web.Controllers
{
    public class IndexController : ApiController
    {
        private readonly INewsService _service;

        public IndexController(INewsService service)
        {
            _service = service;
        }

        [UserAuthenticationFilter]
        [HttpGet]
        [Route("api/News")]
        public IHttpActionResult GetNews()
        {
            return Ok(_service.GetNews(UserHelper.GetIdentity().UserId));
        }
        

        [HttpGet]
        [Route("api/Users/Logout")]
        public IHttpActionResult LogOut()
        {
            //UserHelper.Logout();
            //Request.Headers.Authorization = new AuthenticationHeaderValue("0", "0");
            return Unauthorized();
        }
    }
}

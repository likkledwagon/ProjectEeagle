using System.Threading;
using System.Web.Http.Controllers;
using Eagle.Services.Interfaces;

namespace Eagle.Web.Filters
{
    public class UserAuthenticationFilter : GenericAuthenticationFilter
    {
        protected override bool OnAuthorizeUser(string user, string pass, HttpActionContext filterContext)
        {
            var provider = filterContext.ControllerContext.Configuration
                               .DependencyResolver.GetService(typeof(IUsersService)) as IUsersService;

            var appUser = provider?.Authenticate(user, pass);

            if (appUser == null) return false;

            
            var basicAuthenticationIdentity = Thread.CurrentPrincipal.Identity as BasicAuthenticationIdentity;

            if (basicAuthenticationIdentity == null) return false;

            basicAuthenticationIdentity.UserId = appUser.Id;
            basicAuthenticationIdentity.UserName = appUser.Name;
            
            return true;
        }
    }
}
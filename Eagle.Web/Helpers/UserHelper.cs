using System;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Security;
using Eagle.Web.Filters;

namespace Eagle.Web.Helpers
{
    public class UserHelper
    {
        public static BasicAuthenticationIdentity GetIdentity()
        {
            return Thread.CurrentPrincipal.Identity as BasicAuthenticationIdentity;
        }

        public static void Logout()
        {
            FormsAuthentication.SignOut();

            string authHeaderValue = null;
            //var authRequest = filterContext.Request.Headers.Authorization;
            //if (!string.IsNullOrEmpty(authRequest?.Scheme) && authRequest.Scheme == "Basic")
            //    authHeaderValue = authRequest.Parameter;
            //if (string.IsNullOrEmpty(authHeaderValue))
            //    return null;
            //authHeaderValue = Encoding.Default.GetString(Convert.FromBase64String(authHeaderValue));
            //var credentials = authHeaderValue.Split(':');
            //return credentials.Length < 2 ? null : new BasicAuthenticationIdentity(credentials[0], credentials[1]);

            HttpContext.Current.User =
                new GenericPrincipal(new GenericIdentity(string.Empty), null);
        }
    }
}
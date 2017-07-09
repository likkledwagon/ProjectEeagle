using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace Eagle.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            Bootstrapper.Run(container);
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
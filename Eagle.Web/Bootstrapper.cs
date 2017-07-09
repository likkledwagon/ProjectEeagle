using Eagle.Services.Interfaces;
using Eagle.Services.NewsService;
using Eagle.Services.Users;
using Microsoft.Practices.Unity;

namespace Eagle.Web
{
    public class Bootstrapper
    {
        public static void Run(UnityContainer container)
        {
            container.RegisterType<IUsersService, UsersService>();

            container.RegisterType<INewsService, NewsService>();
        }
    }
}
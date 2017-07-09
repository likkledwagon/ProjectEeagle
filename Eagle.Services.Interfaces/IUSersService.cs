using System.Collections.Generic;
using Eagle.Domain.User;

namespace Eagle.Services.Interfaces
{
    public interface IUsersService
    {
        List<User> GetUsers();
        User Authenticate(string userName, string password);
    }
}

using System.Collections.Generic;
using Eagle.Domain.User;
using Eagle.Services.Interfaces;

namespace Eagle.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly User _item;

        public UsersService()
        {
            _item = new User() { Name = "User1", Id = 1, Group = 1};
        }

        public List<User> GetUsers()
        {
            return new List<User>()
            {
                _item
            };
        }

        public User Authenticate(string userName, string password)
        {
            if (userName != password || password != "1")
                return null;

            return _item;
        }
    }
}

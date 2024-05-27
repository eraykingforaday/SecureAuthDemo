using SecureAuthDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace SecureAuthDemo.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }

    public class UserService : IUserService
    {
        private List<User> _users = new List<User>
        {
            new User { Username = "test", Password = "test" }
        };

        public User Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

            // return null if user not found
            if (user == null)
                return null;

            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }
    }
}
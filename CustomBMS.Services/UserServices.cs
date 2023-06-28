using CustomBMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBMS.Services
{
    public class UserServices : IUserServices
    {
        private readonly IEnumerable<User> _users;

        public  UserServices()
        {
            _users = new List<User>()
                {
                    new User {ID=21,FristName="حسین",LastName="بشارتی",NationalCode="1111111111",PhoneNumber="09182222222" }
                };
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public User Authenticate(AuthenticateVM authenticate)
        {
            User? user = _users.FirstOrDefault<User>(p => p.NationalCode.Equals(authenticate.UserName) && p.PhoneNumber.Equals(authenticate.Password));

            return user;
        }

        public User GetUserById(int id)
        {
            User? user = _users.FirstOrDefault<User>(p => p.ID == id);
            return user;
        }
    }
}

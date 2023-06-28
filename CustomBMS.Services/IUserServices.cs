using CustomBMS.Models;

namespace CustomBMS.Services
{
    public interface IUserServices
    {
        IEnumerable<User> GetAllUsers();
        User Authenticate(AuthenticateVM authenticate);
        User GetUserById(int id);
    }
}
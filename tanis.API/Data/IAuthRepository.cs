using System.Threading.Tasks;
using tanis.API.models;

namespace tanis.API.Data
{
    public interface IAuthRepository
    {
         Task<User> register(User user, string password);

         Task<User> Login(string username, string password);

         Task<bool> UserExists(string username);
    }
}
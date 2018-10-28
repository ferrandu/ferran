using System.Threading.Tasks;
using ferran.api.Models;

namespace ferran.api.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
         
    }
}
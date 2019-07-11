using System.Threading.Tasks;
using Plugin.FirebaseAuth;

namespace Firebase.sample.Cloud.Services
{
    public interface IFirebaseAuthService
    {
        IAuthResult AuthResult { get; }

        Task<bool> LoginAsync(string email, string password);
    }
}
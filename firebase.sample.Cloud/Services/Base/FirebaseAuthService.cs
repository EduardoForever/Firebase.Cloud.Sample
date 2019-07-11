using Firebase.sample.Cloud.Config;
using Plugin.FirebaseAuth;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Firebase.sample.Cloud.Services
{
    public class FirebaseAuthService : IFirebaseAuthService
    {
        private IAuthResult _authResult;

        public IAuthResult AuthResult
        {
            get
            {
                if (this._authResult == null)
                {
                    throw new ArgumentNullException("First you need to log-in to Firebase");
                }

                return this._authResult;
            }
        }

        public async Task<bool> LoginAsync(string email, string password)
        {
            try
            {
                this._authResult = await CrossFirebaseAuth.Current
                        .GetInstance(ApiKeys.FirebaseName)
                        .SignInWithEmailAndPasswordAsync(email, password);
            }
            catch (Exception ex)
            {
                throw;
            }
            

            return this._authResult != null && this._authResult.User != null;
        }
    }
}

using Firebase.sample.Cloud.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firebase.sample.Cloud.Services.Implementation
{
    public class PlacesService : FirebaseDataStore<Place>
    {
        public PlacesService(IFirebaseAuthService firebaseAuthService, string path)
            : base(firebaseAuthService, path)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace firebase.sample.Cloud.Services
{
    public interface IFirebaseAppNameResolver
    {
        string FirebaseAppName { get; }
    }
}

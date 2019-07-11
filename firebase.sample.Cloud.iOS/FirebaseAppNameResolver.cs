using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using firebase.sample.Cloud.Services;
using Foundation;
using UIKit;

namespace firebase.sample.Cloud.iOS
{
    public class FirebaseAppNameResolver: IFirebaseAppNameResolver
    {
        public string FirebaseAppName => "__FIRAPP_DEFAULT";
    }
}
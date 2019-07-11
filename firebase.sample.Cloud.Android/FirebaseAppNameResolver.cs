using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using firebase.sample.Cloud.Services;

namespace firebase.sample.Cloud.Droid
{
    public class FirebaseAppNameResolver: IFirebaseAppNameResolver
    {
        public string FirebaseAppName => "[DEFAULT]";
    }
}
using Autofac;
using firebase.sample.Cloud;
using firebase.sample.Cloud.Services;
using Xamarin.Forms;

namespace Firebase.sample.Cloud.Config
{
    public static class ApiKeys
    {
        public static string FirebaseName
        {
            get
            {
                var container = (Application.Current as App).Container.BeginLifetimeScope();

                using (var scope = container.BeginLifetimeScope())
                {
                    var service = scope.Resolve<IFirebaseAppNameResolver>();

                    return service.FirebaseAppName;
                }
            }
        }

        public const string FirebaseApiKey = "AIzaSyASsPCCqrcMSlQcKEN1eHnQiwutIB5OiA4";
        public const string FirebaseUrl = "https://fir-sample-c6cc7.firebaseio.com/";
        public const string FirebasePath = "places";
    }
}

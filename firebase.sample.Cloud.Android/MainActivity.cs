using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Plugin.CurrentActivity;
using Firebase;
using System.Linq;
using Firebase.sample.Cloud.Config;

namespace firebase.sample.Cloud.Droid
{
    [Activity(Label = "firebase.sample.Cloud", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            
            //var baseOptions = Firebase.FirebaseOptions.FromResource(this);
            //var options = new Firebase.FirebaseOptions.Builder(baseOptions).SetProjectId(baseOptions.StorageBucket.Split('.')[0]).Build();
            //var app = Firebase.FirebaseApp.InitializeApp(this, options, AppName);

            CrossCurrentActivity.Current.Init(this, savedInstanceState);

            LoadApplication(new App(new DroidModule()));

            var options = new FirebaseOptions.Builder()
                .SetApplicationId("1:578994442222:android:7f97e3fdf53da99f")
                .SetApiKey("AIzaSyASsPCCqrcMSlQcKEN1eHnQiwutIB5OiA4")
                .SetProjectId("fir-sample-c6cc7")
                .Build();

            FirebaseApp.InitializeApp(this, options, ApiKeys.FirebaseName);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
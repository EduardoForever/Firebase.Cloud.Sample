using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace firebase.sample.Cloud.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App(new IOSModule()));

            //var options = new FirebaseOptions.Builder()
            //    .SetApplicationId("1:578994442222:android:7f97e3fdf53da99f")
            //    .SetApiKey("AIzaSyASsPCCqrcMSlQcKEN1eHnQiwutIB5OiA4")
            //    .SetProjectId("fir-sample-c6cc7")
            //    .Build();

            Firebase.Core.App.Configure();

            return base.FinishedLaunching(app, options);
        }
    }
}

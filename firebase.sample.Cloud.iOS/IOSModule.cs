using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using firebase.sample.Cloud.Services;
using Foundation;
using UIKit;

namespace firebase.sample.Cloud.iOS
{
    public class IOSModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FirebaseAppNameResolver>().As<IFirebaseAppNameResolver>().SingleInstance();
        }
    }
}
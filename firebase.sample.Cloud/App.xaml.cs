using Autofac;
using Firebase.sample.Cloud.Config;
using Firebase.sample.Cloud.Models;
using Firebase.sample.Cloud.Services;
using Firebase.sample.Cloud.Services.Implementation;
using Firebase.sample.Cloud.ViewModels;
using Firebase.sample.Cloud.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace firebase.sample.Cloud
{
    public partial class App : Application
    {
        public IContainer Container { get; }
        public App(Module module)
        {
            InitializeComponent();

            Container = BuildContainer(module);
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        IContainer BuildContainer(Module module)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<LoginViewModel>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<AddPlaceViewModel>().AsSelf();
            builder.RegisterType<PlaceDetailsViewModel>().AsSelf();
            builder.RegisterType<NavigationService>().AsSelf().SingleInstance();
            builder.RegisterType<MessageService>().AsSelf().SingleInstance();
            builder.RegisterType<FirebaseAuthService>().As<IFirebaseAuthService>().SingleInstance();
            builder.Register(componentContext =>
            {
                return new PlacesService(ApiKeys.FirebasePath);
            }).As<IDataStore<Place>>();

            builder.RegisterModule(module);

            return builder.Build();
        }
    }
}

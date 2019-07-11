using Autofac;
using firebase.sample.Cloud;
using Firebase.sample.Cloud.Models;
using Firebase.sample.Cloud.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Firebase.sample.Cloud.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaceDetailsPage : ContentPage
    {
        public PlaceDetailsPage(Place place)
        {
            InitializeComponent();

            var viewModel = (Application.Current as App).Container.Resolve<PlaceDetailsViewModel>();
            viewModel.Place = place;

            this.BindingContext = viewModel;
        }
    }
}
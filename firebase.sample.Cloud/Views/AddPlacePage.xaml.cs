using Autofac;
using firebase.sample.Cloud;
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
    public partial class AddPlacePage : ContentPage
    {
        public AddPlacePage()
        {
            InitializeComponent();

            this.BindingContext = (Application.Current as App).Container.Resolve<AddPlaceViewModel>();
        }
    }
}
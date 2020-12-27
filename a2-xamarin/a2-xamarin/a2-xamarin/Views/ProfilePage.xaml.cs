using a2_xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace a2_xamarin.Views
{
    public partial class ProfilePage : ContentPage
    {
        ProfileViewModel _viewModel;

        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ProfileViewModel();
        }

        public ProfilePage(string parameter)
        {
            InitializeComponent();

            BindingContext = _viewModel = new ProfileViewModel();
        }
    }
}
using a2_xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace a2_xamarin.Views
{
    public partial class EditProfilePage : ContentPage
    {
        ProfileViewModel _viewModel;
        public EditProfilePage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ProfileViewModel();
        }
    }
}
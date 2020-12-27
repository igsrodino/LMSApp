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
    public partial class CalendarPage : ContentPage
    {
        ProfileViewModel _viewModel;
        public CalendarPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ProfileViewModel();
        }
    }
}
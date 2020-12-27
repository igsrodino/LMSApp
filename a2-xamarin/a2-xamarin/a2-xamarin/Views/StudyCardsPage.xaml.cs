using a2_xamarin.ViewModels;
using System;
using Xamarin.Forms;

namespace a2_xamarin.Views
{
    public partial class StudyCardsPage : ContentPage
    {
        StudyCardsViewModel _viewModel;

    

        public StudyCardsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new StudyCardsViewModel();
        }

    }
}
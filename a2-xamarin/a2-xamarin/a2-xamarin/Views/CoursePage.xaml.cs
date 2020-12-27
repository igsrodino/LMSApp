using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using a2_xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace a2_xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("CourseID", "id")]
    public partial class CoursePage : ContentPage
    {
        public Frame lastFrame;

        public CoursePage()
        {
            InitializeComponent();
        }

        public string CourseID 
        {
            set 
            {
                BindingContext = new CourseViewModel(Uri.UnescapeDataString(value));
            }
        }
    }
}

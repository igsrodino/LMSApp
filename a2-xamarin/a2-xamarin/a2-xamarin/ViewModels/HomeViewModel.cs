using System.Windows.Input;
using Xamarin.Forms;
using a2_xamarin.Views;
using a2_xamarin.Services;
using System.Collections.Generic;
using a2_xamarin.Models;

namespace a2_xamarin.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public IList<Course> Courses { get; set; }

        public HomeViewModel()
        {
            Title = "Your Courses";
            Courses = (IList<Course>) new CourseMockDataStore().GetItemsAsync().Result;
        }
    }
}
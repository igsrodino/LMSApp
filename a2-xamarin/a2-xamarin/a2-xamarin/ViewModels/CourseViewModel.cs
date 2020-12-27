using System.Windows.Input;
using Xamarin.Forms;
using a2_xamarin.Views;
using a2_xamarin.Services;
using System.Collections.Generic;
using a2_xamarin.Models;

namespace a2_xamarin.ViewModels
{
    public class CourseViewModel : BaseViewModel
    {
        public Course Course { get; set; }

        public CourseViewModel(string courseID)
        {
            Course = new CourseMockDataStore().GetItemAsync(courseID).Result;
        }
    }
}
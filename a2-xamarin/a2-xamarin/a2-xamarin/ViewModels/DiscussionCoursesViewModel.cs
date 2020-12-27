using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using a2_xamarin.Models;
using System.Collections.ObjectModel;

namespace a2_xamarin.ViewModels
{
    class DiscussionCoursesViewModel : BaseViewModel
    {
        public ObservableCollection<Course> Courses { get; set; }

        public DiscussionCoursesViewModel()
        {
            CreateCourseCollection();
        }

       
        string name; 
        public String Name
        {
            get => name;
            set
            {
                SetProperty(ref name, Uri.UnescapeDataString(value));
                OnPropertyChanged(nameof(Name));
            }
        }
        void CreateCourseCollection()
        {
            Courses = new ObservableCollection<Course>()
            {
                new Course
                {
                    Name = "Course 1",
                    TeachingPeriod = "Semester 2, 2020",
                    ImageUrl = "https://i.imgur.com/YUBgapf.png"
                },
                new Course
                {
                    Name = "Course 2",
                    TeachingPeriod = "Semester 2, 2020",
                    ImageUrl = "https://i.imgur.com/YUBgapf.png"
                },
            };
        }
    }
}

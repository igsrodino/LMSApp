using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace a2_xamarin.Models
{
    public class Course
    {
        public string Name { get; set; }
        public string TeachingPeriod { get; set; }
        public string ImageUrl { get; set; }
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDesc { get; set; }
        public string ImageURL { get; set; }
        public ICommand GoToDiscussions { get; }
        public ICommand OnCourseTapped { get; }
        public IList<WeekActivities> WeeklyActivities { get; set; }

        public Course()
        {
            OnCourseTapped = new Command<string>(CourseTapped);
            GoToDiscussions = new Command(SendToDiscussions);
        }

        async void CourseTapped(string courseID)
        {
            await Shell.Current.GoToAsync("Course?id="+courseID);
        }
        async void SendToDiscussions()
        {
            await Shell.Current.GoToAsync("Discussions?name=" + Name);
        }
    }
}
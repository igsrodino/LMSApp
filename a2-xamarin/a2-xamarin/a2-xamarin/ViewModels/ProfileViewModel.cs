using a2_xamarin.Models;
using a2_xamarin.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace a2_xamarin.ViewModels
{
    public class ProfileViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                SetProperty(ref name, value);
                OnPropertyChanged(nameof(DisplayName));            
            }
        }
        public string DisplayName
        {
            get
            {
                return $"Name: {Name}";
            }
        }
        private string dob;
        public string DOB
        {
            get
            {
                return dob;
            }
            set
            {
                SetProperty(ref dob, value);
                OnPropertyChanged(nameof(DisplayDOB));
            }
        }
        public string DisplayDOB
        {
            get
            {
                return $"DOB: {DOB}";
            }
        }
        private string organisation;
        public string Organisation
        {
            get
            {
                return organisation;
            }
            set
            {
                SetProperty(ref organisation, value);
                OnPropertyChanged(nameof(DisplayOrganisation));
            }
        }
        public string DisplayOrganisation
        {
            get
            {
                return $"Organisation: {Organisation}";
            }
        }
        private string postaladdress;
        public string PostalAddress 
            {
            get
            {
                return postaladdress;
            }
            set
            {
                SetProperty(ref postaladdress, value);
                OnPropertyChanged(nameof(DisplayPostalAddress));
            }
        }
        public string DisplayPostalAddress
        {
            get
            {
                return $"Postal Address: {PostalAddress}";
            }
        }
        private string emailaddress;
        public string EmailAddress
        {
            get
            {
                return emailaddress;
            }
            set
            {
                SetProperty(ref emailaddress, value);
                OnPropertyChanged(nameof(DisplayEmailAddress));
            }
        }
        public string DisplayEmailAddress
        {
            get
            {
                return $"Email Address: {EmailAddress}";
            }
        }
        private string phonenumber;
        public string PhoneNumber
        {
            get
            {
                return phonenumber;
            }
            set
            {
                SetProperty(ref phonenumber, value);
                OnPropertyChanged(nameof(DisplayPhoneNumber));
            }
        }
        public string DisplayPhoneNumber
        {
            get
            {
                return $"Phone Number: {PhoneNumber}";
            }
        }
        public string UnitTitle
        {
            get
            {
                return $"Units:";
            }
        }
        public string Unit1
        {
            get
            {
                return $"Unit 1";
            }
        }
        public string Unit2
        {
            get
            {
                return $"Unit 2";
            }
        }
        public string Unit3
        {
            get
            {
                return $"Unit 3";
            }
        }
        public string Unit4
        {
            get
            {
                return $"Unit 4";
            }
        }

        public string A1
        {
            get
            {
                return $"A1";
            }
        }
        public string A2
        {
            get
            {
                return $"A2";
            }
        }
        public string A3
        {
            get
            {
                return $"A3";
            }
        }
        public string SemesterStatus
        {
            get
            {
                return $"Status: On-Going";
            }
        }
        public string CurrentSemester
        {
            get
            {
                return $"Semester 1";
            }
        }
        public string Units
        {
            get
            {
                return $"Units:";
            }
        }
        public string AssessmentTitle
        {
            get
            {
                return $"Title of Assessment:";
            }
        }
        public string AssessmentWorth
        {
            get
            {
                return $"Worth: %";
            }
        }
        public string AssessmentAchieved
        {
            get
            {
                return $"Achieved: %";
            }
        }
        public string AssessmentMark
        {
            get
            {
                return $"Mark: /100";
            }
        }
        public string Assessment1
        {
            get
            {
                return $"Assessment 1";
            }
        }
        public string Assessment2
        {
            get
            {
                return $"Assessment 2";
            }
        }
        public string Assessment3
        {
            get
            {
                return $"Assessment 3";
            }
        }

        public string UpcomingTasks
        {
            get
            {
                return $"Upcoming Tasks";
            }
        }
        public string CalendarTask1
        {
            get
            {
                return $"10th - Meeting with Capstone Tutor";
            }
        }
        public string TitleProfile
        {
            get
            {
                return $"My Profile";
            }
        }
        public string TitleEditProfile
        {
            get
            {
                return $"Edit Profile";
            }
        }
        public string TitleGrades
        {
            get
            {
                return $"My Grades";
            }
        }
        public string TitleCalendar
        {
            get
            {
                return $"My Calendar";
            }
        }
        public string Unit1Grades
        {
            get
            {
                return $"1";
            }
        }
        public string Unit2Grades
        {
            get
            {
                return $"2";
            }
        }
        public string Unit3Grades
        {
            get
            {
                return $"3";
            }
        }
        public string Unit4Grades
        {
            get
            {
                return $"4";
            }
        }
        public string CalendarMonth
        {
            get
            {
                return $"October";
            }
        }
        public Command ButtonEditProfile { get; }
        public Command ButtonMyGrades { get; }
        public Command ButtonMyCalendar { get; }
        public Command ButtonProfileConfirm { get; }
        public Command ButtonProfileCancel { get; }
        public Command ButtonSignOut { get; }

        public ProfileViewModel()
        {
            ButtonProfileConfirm = new Command(GoToProfilePage);
            ButtonProfileCancel = new Command(GoToProfilePage);
            ButtonEditProfile = new Command(GoToEditProfilePage);
            ButtonMyGrades = new Command(GoToGradesPage);
            ButtonMyCalendar = new Command(GoToCalendarPage);
            ButtonSignOut = new Command(GoToStartPage);


            async void GoToEditProfilePage()
            {
                await Shell.Current.GoToAsync("EditProfilePage");
            }

            async void GoToGradesPage()
            {
                await Shell.Current.GoToAsync("GradesPage");
            }

            async void GoToCalendarPage()
            {
                await Shell.Current.GoToAsync("CalendarPage");
            }

            async void GoToProfilePage()
            {
                await Shell.Current.GoToAsync("ProfilePage");
            }

            void GoToStartPage()
            {
                App.Current.MainPage = new NavigationPage(new StartPage())
                {
                    BarBackgroundColor = Color.FromHex("#558B2F"),
                    BarTextColor = Color.White,
                }; 
            }
        }
    }
}


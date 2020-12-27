using a2_xamarin.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace a2_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(StudyCardsPage), typeof(StudyCardsPage));
            Routing.RegisterRoute(nameof(Discussions), typeof(Discussions));
            Routing.RegisterRoute(nameof(Threads), typeof(Threads));
            Routing.RegisterRoute(nameof(CalendarPage), typeof(CalendarPage));
            Routing.RegisterRoute("Course", typeof(CoursePage));
            Routing.RegisterRoute(nameof(EditProfilePage), typeof(EditProfilePage));
            Routing.RegisterRoute(nameof(GradesPage), typeof(GradesPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(QuizPage), typeof(QuizPage));
            Routing.RegisterRoute(nameof(QuizResults), typeof(QuizResults));
            Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
            Routing.RegisterRoute(nameof(StartPage), typeof(StartPage));
            Routing.RegisterRoute(nameof(UsersPage), typeof(UsersPage));
        }

    }
}

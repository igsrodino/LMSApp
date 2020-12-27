using System.Linq.Expressions;
using a2_xamarin.Services;
using a2_xamarin.Views;
using Xamarin.Forms;

namespace a2_xamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new NavigationPage(new StartPage())
            {
                BarBackgroundColor = Color.FromHex("#558B2F"),
                BarTextColor = Color.White,
            };

            Routing.RegisterRoute("StartPage", typeof(StartPage));
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
            Routing.RegisterRoute("RegisterPage", typeof(RegisterPage));
            Routing.RegisterRoute("HomePage", typeof(RegisterPage));
            Routing.RegisterRoute("ProfilePage", typeof(ProfilePage));
            Routing.RegisterRoute("EditProfilePage", typeof(EditProfilePage));
            Routing.RegisterRoute("GradesPage", typeof(GradesPage));
            Routing.RegisterRoute("CalendarPage", typeof(CalendarPage));
            Routing.RegisterRoute("Course", typeof(CoursePage));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

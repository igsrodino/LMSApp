using System.Windows.Input;
using Xamarin.Forms;
using a2_xamarin.Views;

namespace a2_xamarin.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string LoginText { get; }
        public string PasswordPlaceholder { get; }
        public string EmailPlaceholder { get; }
        public string SubmitText { get; }

        public LoginViewModel()
        {
            LoginText = "Login";
            PasswordPlaceholder = "Password";
            EmailPlaceholder = "Email";
            SubmitText = "Submit";
            SendToMain = new Command(() => App.Current.MainPage = new AppShell());
        }

        public ICommand SendToMain { get; set; }
    }
}

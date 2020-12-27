using System.Windows.Input;
using Xamarin.Forms;
using a2_xamarin.Views;

namespace a2_xamarin.ViewModels
{
    public class StartViewModel : BaseViewModel
    {
        public string ImageURL { get; set; }
        public string SignInText { get; set; }
        public string JoinNowText { get; set; }

        public StartViewModel()
        {
            ImageURL = "https://i.imgur.com/YUBgapf.png";
            SignInText = "Sign In";
            JoinNowText = "Join Now";
            SendToLogOrReg = new Command<string>(OnSend);
        }

        public ICommand SendToLogOrReg { get; set; }

        async void OnSend(string param)
        {
            if (bool.Parse(param)) await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
            else await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }
    }
}

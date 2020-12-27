using System.Windows.Input;
using Xamarin.Forms;
using a2_xamarin.Views;
using System.Collections.ObjectModel;

namespace a2_xamarin.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public string PageTitle { get; }
        public string FirstNamePlaceholder { get; }
        public string LastNamePlaceholder { get; }
        public string PasswordPlaceholder { get; }
        public string EmailPlaceholder { get; }
        public string OrganisationPlaceholder { get; }
        public string PickerTitle { get; }
        public string SubmitText { get; }
        public ObservableCollection<string> PickerOptions { get; }

        public RegisterViewModel()
        {
            Title = "Register";
            PageTitle = "Register";
            FirstNamePlaceholder = "First Name";
            LastNamePlaceholder = "Last Name";
            PasswordPlaceholder = "Password";
            EmailPlaceholder = "Email";
            OrganisationPlaceholder = "Organisation";
            PickerTitle = "PickerTitle";
            SubmitText = "Submit";
            SendToMain = new Command(() => App.Current.MainPage = new AppShell());
            PickerOptions = new ObservableCollection<string> { "Teacher", "Student" };
        }

        public ICommand SendToMain { get; set; }
    }
}

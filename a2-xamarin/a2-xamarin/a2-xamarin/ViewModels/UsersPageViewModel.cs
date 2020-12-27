using a2_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic;
using System.Windows.Input;
using Xamarin.Forms;

namespace a2_xamarin.ViewModels
{
    class UsersPageViewModel : BaseViewModel
{
        public ObservableCollection<User> Users { get; set; }
        public Command UserDetail { get; }
        public UsersPageViewModel()
        {
            SetupData();
            Title = "Users";
        }

        string name; 
        public string Name
        {
            get => name;
            set
            {
                SetProperty(ref name, Uri.UnescapeDataString(value)); //MvvmHelpers Implementation
                OnPropertyChanged(nameof(Name));
            }
        }
        User user;
        public User SelectedUser
        {
            get => user; //same as get { return name; }
            set
            {
                SetProperty(ref user, value);
                OnPropertyChanged(nameof(SelectedUser));
            }
        }
        void SetupData()
        {
            Users = new ObservableCollection<User>()
            {
                new User
                {
                    Name = "Srikanth Nair"
                },
                new User
                {
                    Name = "NobleGreenApple"
                },
                new User
                {
                    Name = "BraveYellowWatermelon"
                }, 
                new User
                {
                    Name = "CuriousPinkPomelo"
                },
                new User
                {
                    Name = "MysticalPurpleBannana"
                },
                new User
                {
                    Name = "CompassionateGoldenKiwi"
                }
            };
        }
    }
  
}

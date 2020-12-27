using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace a2_xamarin.Models
{
    public class Discussion
    {
        public string CourseID { get; set; }
        public string ThreadID { get; set; }
        public string DiscussionOwnerAvatarURL { get; set; }
        public string DiscussionOwner { get; set; }
        public string DiscussionDesc { get; set; }

        public ICommand GoToThreads { get; }

        public Discussion()
        {
            GoToThreads = new Command(SendToThread);
        }

        async void SendToThread()
        {
            await Shell.Current.GoToAsync("Threads?id=" + ThreadID);
        }
    }
}

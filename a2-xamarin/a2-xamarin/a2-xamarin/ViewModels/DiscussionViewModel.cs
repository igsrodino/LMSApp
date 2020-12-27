using a2_xamarin.Models;
using a2_xamarin.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace a2_xamarin.ViewModels
{
    class DiscussionViewModel : BaseViewModel
    {
        public IList<Discussion> Discussions { get; set; }
        public string DiscussionName { get; set; }

        public DiscussionViewModel(string discussionName)
        {
            //List<Discussion> TempDiscussion = (List<Discussion>) new DiscussionsMockDataStore().GetItemsAsync().Result;
            Discussions = (List<Discussion>) new DiscussionsMockDataStore().GetItemsAsync().Result;
            //List<Discussion> Discussions = TempDiscussion.Where(_d => _d.CourseID == courseID).ToList();
            DiscussionName = discussionName;
        }
    }
}


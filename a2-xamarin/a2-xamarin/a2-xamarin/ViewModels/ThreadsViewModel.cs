using a2_xamarin.Models;
using a2_xamarin.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace a2_xamarin.ViewModels
{
    class ThreadsViewModel : BaseViewModel
    {
        private int commentID = 0;
        public string ThreadID { get; set; }
        public Discussion ThisDiscussion { get; set; }
        public ICommand AddCommentToList { get; set; }

        public ThreadsViewModel(string threadID)
        {
            ThreadID = threadID;
            // TODO: get discussion by thread id from data store and set to ThisDiscussion for unique discussion
            ThisDiscussion = new DiscussionsMockDataStore().GetItemAsync(ThreadID).Result;
            LoadComments();
            AddCommentToList = new Command<string>(OnAddCommentToList);
        }

        ObservableCollection<Comment> comments;
        public ObservableCollection<Comment> Comments
        {
            get => comments;
            set { SetProperty(ref comments, value); }
        }

        void OnAddCommentToList(string commentData) 
        {
            // NOTE: here you would normally pull this info from the user account, but this is a mock without a backend, so this will do for now
            Comments.Add(new Comment 
            {
                CommentID = commentID++,
                CommentOwner = "Student",
                CommentOwnerAvatarURL = "https://i.imgur.com/VARcy69.png",
                CommentText = commentData
            });
        }

        void LoadComments()
        {
            Comments = new ObservableCollection<Comment>()
            {
                new Comment
                {
                    CommentID = commentID++,
                    CommentOwner = "GenerousBlueCherry",
                    CommentOwnerAvatarURL = "https://i.imgur.com/VARcy69.png",
                    CommentText = "Do we compress all our files into a zip folder?"
                },
                new Comment
                {
                    CommentID = commentID++,
                    CommentOwner = "LegendaryOrangeGrape",
                    CommentOwnerAvatarURL = "https://i.imgur.com/VARcy69.png",
                    CommentText = "Are the grades up for Assignment 2?"
                }
            };
        }
    }
}


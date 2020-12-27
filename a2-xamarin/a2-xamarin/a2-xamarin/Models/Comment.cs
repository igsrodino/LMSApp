using System;
using System.Collections.Generic;
using System.Text;

namespace a2_xamarin.Models
{
    class Comment
    {
        public int CommentID { get; set; }
        public string CommentOwner { get; set; }
        public string CommentOwnerAvatarURL { get; set; }
        public string CommentText { get; set; }
    }
}

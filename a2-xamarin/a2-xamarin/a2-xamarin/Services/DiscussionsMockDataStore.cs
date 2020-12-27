using a2_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a2_xamarin.Services
{
    public class DiscussionsMockDataStore : IDataStore<Discussion>
    {
        public readonly IList<Discussion> discussions;

        public DiscussionsMockDataStore()
        {
            discussions = new List<Discussion>()
            {
                new Discussion
                {
                    CourseID = "1",
                    ThreadID = "1",
                    DiscussionOwner = "Srikanth Nair",
                    DiscussionOwnerAvatarURL = "https://i.imgur.com/VARcy69.png",
                    DiscussionDesc = "Make sure you guys submit your assignment before 23:59 on the 30th of June!"
                },
                new Discussion
                {
                    CourseID = "1",
                    ThreadID = "2",
                    DiscussionOwner = "NobleGreenApple",
                    DiscussionOwnerAvatarURL = "https://i.imgur.com/VARcy69.png",
                    DiscussionDesc = "Hey guys! I missed the first tutorial so I didn't get to join a group. Would anyone be willing to work with me?"
                },
                new Discussion
                {
                    CourseID = "1",
                    ThreadID = "3",
                    DiscussionOwner = "CuriousPinkPomelo",
                    DiscussionOwnerAvatarURL = "https://i.imgur.com/VARcy69.png",
                    DiscussionDesc = "What methods/books did you guys use to learn C#?"
                },
                new Discussion
                {
                    CourseID = "2",
                    ThreadID = "4",
                    DiscussionOwner = "LegendaryOrangeGrape",
                    DiscussionOwnerAvatarURL = "https://i.imgur.com/VARcy69.png",
                    DiscussionDesc = "Hello World"
                }
            };
        }

        public async Task<bool> AddItemAsync(Discussion d)
        {
            discussions.Add(d);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Discussion d)
        {
            var oldItem = discussions.Where((Discussion _d) => _d.ThreadID == d.ThreadID).FirstOrDefault();
            discussions.Remove(oldItem);
            discussions.Add(d);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = discussions.Where((Discussion d) => d.ThreadID == id).FirstOrDefault();
            discussions.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Discussion> GetItemAsync(string id)
        {
            return await Task.FromResult(discussions.FirstOrDefault(d => d.ThreadID == id));
        }

        public async Task<IEnumerable<Discussion>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(discussions);
        }
    }
}
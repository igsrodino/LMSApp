using a2_xamarin.Models;
using a2_xamarin.Services;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace a2_xamarin.Controls
{
    class DiscussionsSearchHandler : SearchHandler
    {
        public DiscussionsMockDataStore DMDS { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
               DMDS = new DiscussionsMockDataStore();
                ItemsSource = DMDS.GetItemsAsync().Result
                    .Where(d => d.DiscussionOwner.ToLower().Contains(newValue.ToLower()))
                    .ToList<Discussion>();
            }
        }

        protected override async void OnItemSelected(object d)
        {
            base.OnItemSelected(d);
            await Task.Delay(1000);
            await Shell.Current.GoToAsync($"Threads?id="+((Discussion)d).ThreadID);
        }
    }
}

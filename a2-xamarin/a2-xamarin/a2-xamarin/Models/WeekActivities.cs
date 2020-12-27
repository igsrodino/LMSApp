using System.Collections.Generic;
using Xamarin.Forms;

namespace a2_xamarin.Models
{
    public class WeekActivities
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public IDictionary<string, Command> Activities { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using a2_xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace a2_xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("DiscussionName", "name")]
    public partial class Discussions : ContentPage
    {
        public Discussions()
        {
            InitializeComponent();
        }

        public string DiscussionName
        {
            set
            {
                BindingContext = new DiscussionViewModel(Uri.UnescapeDataString(value));
            }
        }
    }

}
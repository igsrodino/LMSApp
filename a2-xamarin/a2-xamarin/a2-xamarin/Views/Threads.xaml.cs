using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using a2_xamarin.ViewModels;
using System.Diagnostics;

namespace a2_xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("ThreadID", "id")]
    public partial class Threads : ContentPage
    {
        public Threads()
        {
            InitializeComponent();
        }

        public string ThreadID
        {
            set
            {
                BindingContext = new ThreadsViewModel(Uri.UnescapeDataString(value));
            }
        }

        void OnAddCommentClicked(object sender, EventArgs e) 
        {
            addComment.Children.Clear();

            Entry commentText = new Entry()
            {
                PlaceholderColor = Color.FromHex("#E0E0E0"),
                BackgroundColor = Color.FromHex("#BDBDBD")
            };
            commentText.Placeholder = "Enter your comment here...";
            addComment.Children.Add(commentText);

            Button submitComment = new Button();
            submitComment.Text = "Submit";
            submitComment.BindingContext = BindingContext;
            submitComment.SetBinding(Button.CommandProperty, "AddCommentToList");
            submitComment.SetBinding(Button.CommandParameterProperty, new Binding() { Source = commentText, Path = "Text" }); 
            submitComment.Clicked += OnCommentSubmitted;
            addComment.Children.Add(submitComment);
        }

        void OnCommentSubmitted(object sender, EventArgs e)
        {
            addComment.Children.Clear();
            Button addCommentButton = new Button
            {
                Text = "Add Comment",
                FontSize = 13
            };
            addCommentButton.Clicked += OnAddCommentClicked;
            addComment.Children.Add(addCommentButton);
        }
    }
}

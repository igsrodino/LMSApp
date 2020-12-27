using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace a2_xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class QuizResults : ContentPage
{
        public double correctQuestioncount;
        public double numbofQuestions;
        public double percentCorrect;

        public QuizResults(int userAnswers, int numOfQuestions)
        {
            InitializeComponent();
            // Two lines below take values from the QuizPage.xaml.cs
            correctQuestioncount = userAnswers;
            numbofQuestions = numOfQuestions;
            // Rounded the percentage of correct answers to two decimal places.
            percentCorrect = Math.Round((correctQuestioncount / numbofQuestions * 100), 2);
            NumOfCorrectAnswers.Text = "You answered " + correctQuestioncount + "/" + numbofQuestions + " questions correctly (" + percentCorrect + "%).";
        }

        // Links to the courses page.
        async void ReturnToCourse(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
using a2_xamarin.ViewModels;
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
    public partial class QuizPage : ContentPage
    {
        QuizViewModel _viewModel;
        

        // Equivalent of a hashtable, used for listing the answers a user has selected in the quiz.
        public Dictionary<int, int> UserAnswers = new Dictionary<int, int>();

        public int CorrectAnswers;

        // The number of questions in the Question list from QuizViewModel.
        public int numberOfQuestions;

        // Used to see how many answers a user has entered using the radio buttons.
        public int UserAnswerCount;

        public QuizPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new QuizViewModel();
        }

        // Function for radio buttons, adds a value to a hashmap to indicate that user has answered true or false to the question.
        public void OnQuestionOptionChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            // Sees which radio button is checked, and adds the appropriate value to the answers hashmap alongside the question number.
            if (button.IsChecked)
            {
                Int32.TryParse(button.GroupName, out int questionNumb);
                if (button.Text == "True")
                {
                    // If the users answer for a question already exists, then remove it so a
                    // new one can be added.
                    if (UserAnswers.ContainsKey(questionNumb))
                    {
                        UserAnswers.Remove(questionNumb);
                        // Maybe add an if statement that checks if the dictionary key exists. If it does, update the value to true.
                        UserAnswers.Add(questionNumb, 1);
                    }
                    else
                    {
                        UserAnswers.Add(questionNumb, 1);
                    }
                }
                else if (button.Text == "False")
                {
                    if (UserAnswers.ContainsKey(questionNumb))
                    {
                        UserAnswers.Remove(questionNumb);
                        UserAnswers.Add(questionNumb, 0);
                    }
                    else
                    {
                        UserAnswers.Add(questionNumb, 0);
                    }
                }

            }
        }

        // The submit button function. Sends the number of correct answers a user made to the QuizResults page.
        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Checks if the answer provided by user matches the correct answer in the Questions list.
            foreach (KeyValuePair<int, int> entry in UserAnswers)
            {
                UserAnswerCount++;

                if (_viewModel.Questions.ElementAt(entry.Key - 1).answer == entry.Value)
                {
                    CorrectAnswers++;
                }
            }
            // Counts the number of questions.
            foreach (Question q in _viewModel.Questions)
            {
                numberOfQuestions++;
            }

            // Opens the QuizResults page, sending the users answers to it as a paramter.
            await Navigation.PushAsync(new QuizResults(CorrectAnswers, numberOfQuestions));

        }
    }
}
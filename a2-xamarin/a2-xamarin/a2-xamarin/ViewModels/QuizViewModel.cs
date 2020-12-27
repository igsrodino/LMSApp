using a2_xamarin.ViewModels;
using a2_xamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace a2_xamarin.ViewModels
{
    public class QuizViewModel : BaseViewModel
    {

        // A list of questions to be displayed.
        public IList<Question> Questions { get; set; }
        public QuizViewModel()
        {
            Title = "Quiz Interface";
            SetupData();
        }


        // Creates the list of questions for the view to display. Also used in checking the users answers with the answer number.
        void SetupData()
        {

            Questions = new List<Question>()


            {
                new Question
                {
                    QuestionNumber = 1,
                    QuestionText = "SWOT stands for Strengths, Weaknesses, Opportunities, and Threats.",
                    answer = 1
                },
                new Question
                {
                    QuestionNumber = 2,
                    QuestionText = "A competitor analysis focuses on the strengths and weaknesses of current and potential competitors.",
                    answer = 1
                },
                new Question
                {
                    QuestionNumber = 3,
                    QuestionText = "MVP stands for Minimum Viable Product.",
                    answer = 1
                },
                new Question
                {
                    QuestionNumber = 4,
                    QuestionText = "There are only two types of prototypes; low fidelity, and high fidelity.",
                    answer = 0
                },
                new Question
                {
                    QuestionNumber = 5,
                    QuestionText = "The four activities in the Design Science Process Model are: Problem Identification and Design Motivation, Competitor Analysis and Design Objectives, Design and Development and Demonstration and Evaluation.",
                    answer = 1
                },
                new Question
                {
                    QuestionNumber = 6,
                    QuestionText = "Design science is fundamentally a problem-solving paradigm",
                    answer = 1
                }
            };
        }

    }
}
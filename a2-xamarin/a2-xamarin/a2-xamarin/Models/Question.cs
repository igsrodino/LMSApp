using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace a2_xamarin
{
    // Model for the Questions list in QuizViewModel.
	public class Question
{
    public string QuestionText { get; set; }

        public int QuestionNumber { get; set; }
    
        // The answer for the question (either 1 or 0)
        public int answer { get; set; }

    }
}
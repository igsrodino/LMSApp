using a2_xamarin.Models;
using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Windows.Input;
using System.Linq;

namespace a2_xamarin.ViewModels
{
    public class StudyCardsViewModel : BaseViewModel
    {
        public int cardNum = -1;
        public IDictionary<int, StudyCard> Questions { get; set; }
        string _CurrentStudyCard;

        public string CurrentStudyCard 
        {
            get { return _CurrentStudyCard; }
            set { SetProperty(ref _CurrentStudyCard, value); }
        }

        public StudyCardsViewModel()
        {
            Title = "Study Cards";
            UpdateCard = new Command<string>(OnUpdateCard);
            Questions = new Dictionary<int, StudyCard>();

            PopulateQuestionsListCourse2Week1();
            UpdateCurrentStudyCard(1);
        }

        public ICommand UpdateCard { get; }

        void OnUpdateCard(string dirParam) 
        {
            if (int.TryParse(dirParam, out int dir)) UpdateCurrentStudyCard(dir);
        }

        public void UpdateCurrentStudyCard(int dir) 
        {
            cardNum = Math.Min(Math.Max(cardNum + dir, 0), Questions.Count - 1);
            StudyCard nextCard = Questions.ElementAt(cardNum).Value;
            CurrentStudyCard = dir == 0 ? nextCard.Answer : nextCard.Question;
        }

        public void PopulateQuestionsListCourse2Week1() 
        {
            Questions.Add(0, new StudyCard
            {
                Question = "In jury trials, how is the responsibility to make judicial decision divided?",
                Answer = "The judge presents the legal issues and relevant laws to the issue at stake to the jury who finds facts"
            });
            Questions.Add(1, new StudyCard
            {
                Question = "In a trial, what happens where there is on jury?",
                Answer = "The judge, magistrate or tribunal member will find facts and apply facts to the law to arrive with verdict"
            });
            Questions.Add(2, new StudyCard
            {
                Question = "What are two sources of law?",
                Answer = "Witnesses may not give exact description of what occurred either from bias or poor recollection"

            });
            Questions.Add(3, new StudyCard
            {
                Question = "What type of evidence may be presented to court or tribunal?",
                Answer = "Circumstantial evidence may be provided to court or tribunal"
            });
            Questions.Add(4, new StudyCard
            {
                Question = "What is direct evidence?",
                Answer = "Evidence from eye witness that if accepted is used as as material fact for a case"
            });
            Questions.Add(5, new StudyCard
            {
                Question = "What is the process of fact-finding",
                Answer = "Fact-finder will have to gather evidential statements made by eye witnesses"
            });
            Questions.Add(6, new StudyCard
            {
                Question = "What are some rules of evidence in court that governs whether evidence should be admitted or excluded?",
                Answer = "The testimony delivered by witness should not contain hearsay and needs to be exactly what they witnessed"

            });
            Questions.Add(7, new StudyCard
            {
                Question = "Who can make grounds for appeal?",
                Answer = "The unsuccessful party of a trial"
            });
        }

        public void PopulateQuestionsListCourse2Week2()
        {
            Questions.Add(0, new StudyCard
            {
                Question = "In criminal appeals, who does the criminal law favour?",
                Answer = "Favours defendants due to fewer resources than state"
            });
            Questions.Add(1, new StudyCard
            {
                Question = "When may acquittal on serious charged be appealed?",
                Answer = "'Fresh and compelling evidence' of guilt and interference with the decision of the jury"
            });
            Questions.Add(2, new StudyCard
            {
                Question = "When an appeal has been made on an acquittal on a serious charge, which court does this go to?",
                Answer = "The Court of Appeal where the retrial will be held to overturn the acquittal for serious charges"

            });
            Questions.Add(3, new StudyCard
            {
                Question = "Is the double jeopardy protection for used?",
                Answer = "It is not used in jury trials in australia and very few cases in England have adopted this"
            });
            Questions.Add(4, new StudyCard
            {
                Question = "What is the common law precedent based on?",
                Answer = "Hierarchical structure of court system"
            });
            Questions.Add(5, new StudyCard
            {
                Question = "What does the hierarchy courts variance depend on?",
                Answer = "Jurisdiction"
            });
            Questions.Add(6, new StudyCard
            {
                Question = "Can matters outside the federal jurisdiction be brought to federal courts?",
                Answer = "Federal courts can deal with non federal matters these known as 'accured' or 'associated' jurisdictions"

            });
            Questions.Add(7, new StudyCard
            {
                Question = "What is the role of administrative tribunals?",
                Answer = "To abjudicate disputes"
            });
        }

    }
}
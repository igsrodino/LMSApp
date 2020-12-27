using a2_xamarin.Models;
using a2_xamarin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace a2_xamarin.Services
{
    public class CourseMockDataStore : IDataStore<Course>
    {
        readonly List<Course> courses;

        public CourseMockDataStore()
        {
            courses = new List<Course>()
            {
                new Course
                {
                    CourseID = "1",
                    ImageURL="https://i.imgur.com/YUBgapf.png",
                    CourseName="Course #1",
                    CourseDesc="Very short course description that shows the user what the course is about",
                    WeeklyActivities = new List<WeekActivities>
                    {
                        new WeekActivities()
                        {
                            Title = "Week 1",
                            Desc = "This week will introduce the basics and fundamentals we will need for the following weeks.",
                            Activities = new Dictionary<string, Command>()
                            { 
                                ["Lecture Video"] = new Command(() => {}),
                                ["Tutorial PDF"] = new Command(() => {}),
                                ["Quiz"] = new Command(async () => await Shell.Current.GoToAsync(nameof(QuizPage))),
                                ["Tutorial Video"] = new Command(() => {})
                            }
                        },
                        new WeekActivities()
                        {
                            Title = "Week 2",
                            Desc = "This week will build on what we learnt last week.",
                            Activities = new Dictionary<string, Command>()
                            {
                                ["Lecture Video"] = new Command(() => {}),
                                ["Tutorial PDF"] = new Command(() => {}),
                                ["Quiz"] = new Command(async () => await Shell.Current.GoToAsync(nameof(QuizPage))),
                                ["Tutorial Video"] = new Command(() => {})
                            }
                        }
                    }
                },
                new Course 
                { 
                    CourseID = "2", 
                    ImageURL="https://i.imgur.com/YUBgapf.png", 
                    CourseName="Course #2", 
                    CourseDesc="Very short course description that shows the user what the course is about",
                    WeeklyActivities = new List<WeekActivities>
                    {
                        new WeekActivities()
                        {
                            Title = "Week 1",
                            Desc = "",
                            Activities = new Dictionary<string, Command>()
                            {
                                ["Lecture Video"] = new Command(() => {}),
                                ["Tutorial PDF"] = new Command(() => {}),
                                ["Study Card Revision"] = new Command(async () => await Shell.Current.GoToAsync("StudyCardsPage")),
                                ["Tutorial Video"] = new Command(() => {})
                            }
                        },
                        new WeekActivities()
                        {
                            Title = "Week 2",
                            Desc = "This week will build on what we learnt last week",
                            Activities = new Dictionary<string, Command>()
                            {
                                ["Lecture Video"] = new Command(() => {}),
                                ["Tutorial PDF"] = new Command(() => {}),
                                ["Study Card Revision"] = new Command(async () => await Shell.Current.GoToAsync("StudyCardsPage")),
                                ["Tutorial Video"] = new Command(() => {})
                            }
                        }
                    }
                }
            };
        }

        public async Task<bool> AddItemAsync(Course c)
        {
            courses.Add(c);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Course c)
        {
            var oldItem = courses.Where((Course _c) => _c.CourseID == c.CourseID).FirstOrDefault();
            courses.Remove(oldItem);
            courses.Add(c);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string courseID)
        {
            var oldItem = courses.Where((Course c) => c.CourseID == courseID).FirstOrDefault();
            courses.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Course> GetItemAsync(string courseID)
        {
            return await Task.FromResult(courses.FirstOrDefault(c => c.CourseID == courseID));
        }

        public async Task<IEnumerable<Course>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(courses);
        }
    }
}
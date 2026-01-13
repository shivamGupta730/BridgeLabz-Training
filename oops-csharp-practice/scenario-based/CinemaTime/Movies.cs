using System;

namespace BridgeLabzTraining.scenrio_based_problem.CinemaTime
{
    internal class Movies
    {
        private string title;
        private string time;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public Movies(string title, string time)
        {
            Title = title;
            Time = time;
        }

       
        public override string ToString()
        {
            return "Movie: " + Title + " | Time: " + Time;
        }
    }
}

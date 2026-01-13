using System;

namespace BridgeLabzTraining.scenrio_based_problem.CinemaTime
{
    internal class MovieUtility : IMovieService
    {
        private Movies[] movies = new Movies[100]; 
        private int count = 0;                   // tracks number of movies

        public void AddMovie(string title, string time)
        {
            if (!IsValidTime(time))
            {
                Console.WriteLine("Invalid time format. Use HH:MM");
                return;
            }

            if (count >= movies.Length)
            {
                Console.WriteLine("Movie storage is full.");
                return;
            }

            movies[count] = new Movies(title, time);
            count++;

            Console.WriteLine("Movie added successfully.");
        }

        public void SearchMovie(string keyword)
        {
            bool isFound = false;

            for (int i = 0; i < count; i++)
            {
                if (movies[i].Title.Contains(keyword))
                {
                    Console.WriteLine(
                        "Movie: " + movies[i].Title + " | Time: " + movies[i].Time
                    );
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No movie found with this keyword.");
            }
        }

        public void DisplayAllMovies()
        {
            if (count == 0)
            {
                Console.WriteLine("No movies available.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(
                    "Movie: " + movies[i].Title + " | Time: " + movies[i].Time
                );
            }
        }

        private bool IsValidTime(string time)
        {
            if (!time.Contains(":"))
                return false;

            string[] parts = time.Split(':');

            if (parts.Length != 2)
                return false;

            int hour = int.Parse(parts[0]);
            int minute = int.Parse(parts[1]);

            if (hour < 0 || hour > 23)
                return false;

            if (minute < 0 || minute > 59)
                return false;

            return true;
        }
    }
}

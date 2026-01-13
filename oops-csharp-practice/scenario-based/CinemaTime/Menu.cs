using System;

namespace BridgeLabzTraining.scenrio_based_problem.CinemaTime
{
    internal class Menu
    {
        private IMovieService movieService;

        public Menu(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        public void ShowMenu()
        {
            bool running = true;

            while (running)
            {
                PrintMenu();
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddMovieMenu();
                        break;

                    case 2:
                        SearchMovieMenu();
                        break;

                    case 3:
                        movieService.DisplayAllMovies();
                        break;

                    case 4:
                        running = false;
                        Console.WriteLine("Thank you for using CinemaTime.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("\n=== CinemaTime – Movie Schedule Manager ===");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Search Movie");
            Console.WriteLine("3. Display All Movies");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
        }

        private void AddMovieMenu()
        {
            Console.Write("Enter movie title: ");
            string title = Console.ReadLine();

            Console.Write("Enter show time (HH:MM): ");
            string time = Console.ReadLine();

            movieService.AddMovie(title, time);
        }

        private void SearchMovieMenu()
        {
            Console.Write("Enter keyword to search: ");
            string keyword = Console.ReadLine();

            movieService.SearchMovie(keyword);
        }
    }
}

using System;

namespace BridgeLabzTraining.scenrio_based_problem.CinemaTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovieService movieService = new MovieUtility();
            Menu menu = new Menu(movieService);
            menu.ShowMenu();
        }
    }
}

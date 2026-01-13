using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenrio_based_problem.CinemaTime
{
    internal interface IMovieService
    {
        void AddMovie(string title, string time);
        void SearchMovie(string keyword);
        void DisplayAllMovies();
    }
}

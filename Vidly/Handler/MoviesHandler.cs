
using System.Collections.Generic;
using Vidly.Classes;

namespace Vidly.Handler
{
    public class MoviesHandler
    {
        public  MoviesHandler( )
        {
            this.MovieList = new List<MovieClass>();
        }

        public List<MovieClass> MovieList;
    }
}
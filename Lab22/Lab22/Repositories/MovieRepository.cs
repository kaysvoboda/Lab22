using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab22.Models;

namespace Lab22.Repositories
{
    public class MovieRepository:IMovieRepository
    {
        private readonly List<MovieViewModel> _movies = new List<MovieViewModel>();

        public List<MovieViewModel> Get()
        {
            return _movies;
        }

        public void Save(MovieViewModel movie)
        {
            _movies.Add(movie);
        }
    }
}

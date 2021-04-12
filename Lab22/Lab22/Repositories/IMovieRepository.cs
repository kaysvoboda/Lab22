using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab22.Models;

namespace Lab22.Repositories
{
    public interface IMovieRepository
    {
        List<MovieViewModel> Get();
        void Save(MovieViewModel movie);
    }
}

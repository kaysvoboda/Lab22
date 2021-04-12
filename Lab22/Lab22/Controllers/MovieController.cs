using Lab22.Models;
using Lab22.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _repository;

        public MovieController(IMovieRepository repository)
        {
            _repository = repository;
        }

        public IActionResult SearchResultGenre(MovieSearchViewModel model)
        {
            var list = _repository.Get().Where(x => x.Genre == model.Genre);
            return View(list);
        }

        public IActionResult SearchResultTitle(MovieSearchViewModel model)
        {
            var list = _repository.Get().Where(x => x.Title.Contains(model.Title));
            return View(list);
        }
    }
}

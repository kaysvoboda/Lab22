using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Models
{
    public class MovieSearchViewModel : Controller
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public IActionResult Index()
        {
            return View();
        }
    }
}

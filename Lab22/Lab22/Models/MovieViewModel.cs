using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab22.Models
{
    public class MovieViewModel
    { 
    
        public MovieViewModel(string title, MovieGenre genre)
        {
            Title = title;
            Genre = genre;
        }
        public string Title { get; }
        public string Genre { get; }
    }
}

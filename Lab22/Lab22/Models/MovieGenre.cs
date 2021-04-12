using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Models

{

    public class MovieGenre
    {

        [EnumDataType(typeof(Genre))]
        public MovieGenre GenreType { get; set; }
    }


    public enum Genre
    {
        Action,
        SciFi,
        Drama,
        Comedy,
        Horror
    }
}

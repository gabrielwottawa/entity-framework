using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicMVC.Models
{
    public class Genre
    {
        public int GenreID { get; set; }

        [Display(Name = "Genre Name")]
        [StringLength(50, MinimumLength = 3)]
        public string GenreName { get; set; }
    }
}
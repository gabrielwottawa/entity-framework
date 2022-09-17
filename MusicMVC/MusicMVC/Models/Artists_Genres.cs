using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicMVC.Models
{
    public class Artists_Genres
    {
        public int Artists_GenresID { get; set; }

        [Display(Name = "Genre Name")]
        public int GenreID { get; set; }
        public Genre Genres { get; set; }

        [Display(Name = "Artist Name")]
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
    }
}
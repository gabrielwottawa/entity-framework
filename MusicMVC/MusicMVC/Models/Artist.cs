using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicMVC.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        [Display(Name = "Artist Name")]
        public string ArtistName { get; set; }

        [Display(Name = "Music Name")]
        public int MusicID { get; set; }
        public virtual Music Music { get; set; }
    }
}
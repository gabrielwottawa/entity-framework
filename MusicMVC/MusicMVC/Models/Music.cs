using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicMVC.Models
{
    public class Music
    {
        public int MusicID { get; set; }

        [Display(Name = "Music Name")]
        [StringLength(50, MinimumLength = 3)]
        public string MusicName { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RelaseDate { get; set; }

        [Display(Name = "Album Name")]
        public int AlbumID { get; set; }
        public virtual Album Album { get; set; }
    }
}
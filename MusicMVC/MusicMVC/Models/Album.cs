using System;
using System.ComponentModel.DataAnnotations;

namespace MusicMVC.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        [Display(Name = "Album Name")]
        public string AlbumName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")]
        public DateTime RelaseDate { get; set; }
    }
}
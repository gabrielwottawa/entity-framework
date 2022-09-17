using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicMVC.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("MusicContext") { }

        public System.Data.Entity.DbSet<MusicMVC.Models.Album> Albums { get; set; }

        public System.Data.Entity.DbSet<MusicMVC.Models.Artist> Artists { get; set; }

        public System.Data.Entity.DbSet<MusicMVC.Models.Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<MusicMVC.Models.Music> Musics { get; set; }

        public System.Data.Entity.DbSet<MusicMVC.Models.Artists_Genres> Artists_Genres { get; set; }
    }
}
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

        public DbSet<Models.Album> Albums { get; set; }

        public DbSet<Models.Artist> Artists { get; set; }

        public DbSet<Models.Genre> Genres { get; set; }

        public DbSet<Models.Music> Musics { get; set; }

        public DbSet<Models.Artists_Genres> Artists_Genres { get; set; }
    }
}
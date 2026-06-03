using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Q2.Models
{
    public class MoviesDBContext : DbContext
    {
        public MoviesDBContext() : base("MoviesDB") { }

        public DbSet<Movie> Movies { get; set; }
    }
}
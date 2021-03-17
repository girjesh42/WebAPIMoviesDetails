using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppCoreMoviesAPI.Models;

namespace WebAppCoreMoviesAPI.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext (DbContextOptions<MoviesDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppCoreMoviesAPI.Models.Movie> Movie { get; set; }
    }
}

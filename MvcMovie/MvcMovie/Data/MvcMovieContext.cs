using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContex : DbContext 
    {
        public MvcMovieContex(DbContextOptions<MvcMovieContex> options)
            : base(options)
        { 
            
        }

        public DbSet<Movie> Movies { get; set; }
    }
}

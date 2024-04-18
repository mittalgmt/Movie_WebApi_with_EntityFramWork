using Microsoft.EntityFrameworkCore;
using Movie_WebApi_with_ENtityFramWork.Model;
using System.Collections.Generic;

namespace Movie_WebApi_with_ENtityFramWork.Data
{
    public class MovieDbContex : DbContext
    {
        public MovieDbContex(DbContextOptions<MovieDbContex> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}

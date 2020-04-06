// Unused usings removed.
using Microsoft.EntityFrameworkCore;
using SportsData.Models;  // Enables public DbSet<Movie> Movie

namespace SportsData.Data
{
    public class SportsDataContext : DbContext
    {
        public SportsDataContext (DbContextOptions<SportsDataContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class SportsStatsContext : DbContext
    {
        public SportsStatsContext(DbContextOptions<SportsStatsContext> options)
            : base(options)
        {
        }

        public DbSet<SportsStats> SportsStats { get; set; }
    }
}

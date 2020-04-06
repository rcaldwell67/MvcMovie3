using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsData.Models;

namespace SportsData.Data
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

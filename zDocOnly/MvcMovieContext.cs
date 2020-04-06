﻿#if NEVER
#region snippet
using Microsoft.EntityFrameworkCore;
using SportsData.Models;

namespace SportsData.Data
{
    public class SportsDataContext : DbContext
    {
        public SportsDataContext (DbContextOptionsSportsDataContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
#endregion
#endif
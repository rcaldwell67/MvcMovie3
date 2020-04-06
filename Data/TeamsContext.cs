using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsData.Models;
using System.Data.Entity.Infrastructure;

namespace SportsData.Data
{
    public class TeamsContext : DbContext
    {
        //public TeamsContext()
        //{
        //    (this as IObjectContextAdapter).ObjectContext.ContextOptions.UseCSharpNullComparisonBehavior = true;
        //}

        public TeamsContext(DbContextOptions<TeamsContext> options)
            : base(options)
        {

        }

        public DbSet<Teams> Teams { get; set; }
    }
}

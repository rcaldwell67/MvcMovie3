using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMovie.Models;
using System.Data.Entity.Infrastructure;

namespace MvcMovie.Data
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

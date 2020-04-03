using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class Sports_HistoryContext : DbContext
    {
        public Sports_HistoryContext(DbContextOptions<Sports_HistoryContext> options)
            : base(options)
        {
        }

        public DbSet<Sports_History> Sports_History { get; set; }
        
    }
}

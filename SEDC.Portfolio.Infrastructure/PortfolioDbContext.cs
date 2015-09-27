using SEDC.Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Portfolio.Infrastructure
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<PortfolioItem> PortfolioItems { get; set; }
        public DbSet<JournalItem> JournalItems { get; set; }
    }
}

using SEDC.Portfolio.Core.Entities;
using SEDC.Portfolio.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Portfolio.Infrastructure
{

    public class PortfolioDbContext : DbContext //, IContext
    {
        public PortfolioDbContext()
            : base("name=PortfolioDbContextContextConnectionString")
        {
            var a = Database.Connection.ConnectionString;
        }

        //public class PortfolioDbContext : DbContext
        //{

        //    public PortfolioDbContext(string connectionString)
        //        : base(connectionString)
        //    {
        //    }



        public IDbSet<User> Users { get; set; }
        public IDbSet<Skill> Skills { get; set; }
        public IDbSet<Tag> Tags { get; set; }
        public IDbSet<Service> Services { get; set; }
        public IDbSet<PortfolioItem> PortfolioItems { get; set; }
        public IDbSet<JournalItem> JournalItems { get; set; }

        //public IQueryable<User> People
        //{
        //    get { return this.Users; }
        //    set { this.Users = (IDbSet<User>)value; }
        //}

        //IQueryable<Skill> IContext.Skills
        //{
        //    get { return this.Skills; }
        //    set { this.Skills = (IDbSet<Skill>)value; }
        //}

        //public IQueryable<Service> Servicess
        //{
        //    get { return this.Services; }
        //    set { this.Services = (IDbSet<Service>)value; }
        //}

        //public IQueryable<Tag> Tagss
        //{
        //    get { return this.Tags; }
        //    set { this.Tags = (IDbSet<Tag>)value; }
        //}

        //IQueryable<PortfolioItem> IContext.PortfolioItems
        //{
        //    get { return this.PortfolioItems; }
        //    set { this.PortfolioItems = (IDbSet<PortfolioItem>)value; }
        //}

        //IQueryable<JournalItem> IContext.JournalItems
        //{
        //    get { return this.JournalItems; }
        //    set { this.JournalItems = (IDbSet<JournalItem>)value; }
        //}

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //        .HasKey(x => x.ID)
        //        .Property(x => x.ID)
        //        .HasColumnName("ID");

        //    modelBuilder.Entity<Skill>().HasKey(x => x.ID);
        //    modelBuilder.Entity<Tag>().HasKey(x => x.ID);
        //    modelBuilder.Entity<Service>().HasKey(x => x.ID);
        //    modelBuilder.Entity<PortfolioItem>().HasKey(x => x.ID);
        //    modelBuilder.Entity<JournalItem>().HasKey(x => x.ID);


        //    base.OnModelCreating(modelBuilder);
        //}

        //public void Add<T>(T obj) where T : BaseEntity
        //{
        //    this.Set<T>().Add(obj);
        //}

        //public void Save()
        //{
        //    base.SaveChanges();
        //}
    }
}

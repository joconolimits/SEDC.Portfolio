using SEDC.Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Portfolio.Core.Interfaces
{
    public interface IContext
    {
        IQueryable<User> People { get; set; }
        IQueryable<Skill> Skills { get; set; }
        IQueryable<Service> Servicess { get; set; }
        IQueryable<Tag> Tagss { get; set; }
        IQueryable<PortfolioItem> PortfolioItems { get; set; }
        IQueryable<JournalItem> JournalItems { get; set; }
        void Add<T>(T obj) where T : BaseEntity;
        void Save();
    }
}

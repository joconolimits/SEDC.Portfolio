using SEDC.Portfolio.Core.Entities;
using SEDC.Portfolio.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Portfolio.Infrastructure
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        //public TagRepository(PortfolioDbContext context)
        //    : base()
        //{
        //}
    }
}

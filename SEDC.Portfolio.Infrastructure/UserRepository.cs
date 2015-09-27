using SEDC.Portfolio.Core.Entities;
using SEDC.Portfolio.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Portfolio.Infrastructure
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(PortfolioDbContext context)
            : base(context)
        {
        }
    }
}

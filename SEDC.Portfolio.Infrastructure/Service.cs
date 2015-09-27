﻿using SEDC.Portfolio.Core.Entities;
using SEDC.Portfolio.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Portfolio.Infrastructure
{
    public class ServiceRepository : BaseRepository<Service>, IServiceRepository
    {
        public ServiceRepository(PortfolioDbContext context)
            : base(context)
        {
        }
    }
}

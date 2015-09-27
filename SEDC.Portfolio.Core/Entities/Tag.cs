using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Portfolio.Core.Entities
{
    public class Tag : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PortfolioItem> PortfolioItems { get; set; }
    }
}

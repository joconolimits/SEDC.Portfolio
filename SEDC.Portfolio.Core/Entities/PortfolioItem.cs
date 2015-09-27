using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Portfolio.Core.Entities
{
    public class PortfolioItem : BaseEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProjcetUrl { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}

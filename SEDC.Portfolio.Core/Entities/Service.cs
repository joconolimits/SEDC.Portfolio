using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Portfolio.Core.Entities
{
    public class Service : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
    }
}

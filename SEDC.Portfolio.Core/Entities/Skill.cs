using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Portfolio.Core.Entities
{
    public class Skill : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Percentage { get; set; }
    }
}

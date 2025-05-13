using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Core.Entities
{
    public class MaturityLevel : BaseEntity
    {
        public string Level { get; set; }
        public int Value { get; set; }
        public string Documentation { get; set; }
        public string Implementation { get; set; }

        //navigation props
        public Guid MaturityId { get; set; }
        public Maturity Maturity { get; set; }
    }
}

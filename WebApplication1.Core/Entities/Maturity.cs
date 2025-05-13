using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Core.Entities
{
    public class Maturity : BaseDescriptionEntity
    {
        public string Name { get; set; }
        public int Threshold { get; set; }

        //navigational property
        public ICollection<MaturityLevel> MaturityLevels { get; set; }
        public ICollection<Assessment> Assessments { get; set; }
    }
}

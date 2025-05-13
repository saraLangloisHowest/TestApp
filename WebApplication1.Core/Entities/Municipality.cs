using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Core.Entities
{
    public class Municipality : BaseDescriptionEntity
    {
        public string Name { get; set; }
        public ICollection<Assessment> Assessments { get; set; }
    }
}

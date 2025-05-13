using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Core.Entities
{
    public class Guidance : BaseDescriptionEntity
    {
        public int Order { get; set; }
        public Requirement Requirement { get; set; }
        public Guid RequirementId { get; set; }
        public bool IsTitle { get; set; }
    }
}

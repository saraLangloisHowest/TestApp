using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Core.Entities
{
    public class Requirement : BaseDescriptionEntity
    {
        public string Name { get; set; }
        public ICollection<Score> Scores { get; set; } 
        public ICollection<Guidance> Guidances { get; set; }

        public SubCategory SubCategory { get; set; }
        public Guid SubCategoryId { get; set; }

        public int Order { get; set; }
    }
}

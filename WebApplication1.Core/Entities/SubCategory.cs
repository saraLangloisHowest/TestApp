using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Core.Entities
{
    public class SubCategory: BaseDescriptionEntity
    {
        public Category Category {get; set;}
        public Guid CategoryId { get; set; }
        public int Order {  get; set; }

        public string Name { get; set; }
        public ICollection<Requirement> Requirements { get; set; }
        
    }
}

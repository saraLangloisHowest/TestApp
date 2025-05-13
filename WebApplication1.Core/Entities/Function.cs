using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Core.Entities
{
    public class Function: BaseDescriptionEntity
    {
        public int Order {  get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}

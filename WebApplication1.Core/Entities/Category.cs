using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Core.Entities
{
    public class Category : BaseDescriptionEntity
    {
        public ICollection<SubCategory> SubCategories { get; set; }
        public int Order {  get; set; }
        public Function Function {get; set;}
        public Guid FunctionId { get; set; }
        public string Name { get; set; }
    }
}

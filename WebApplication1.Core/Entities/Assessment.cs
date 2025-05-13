using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace WebApplication1.Core.Entities
{
    public class Assessment : BaseEntity
    {
        public Municipality Municipality { get; set; }
        public Guid MunicipalityId { get; set; }
        public ApplicationUser User { get; set; }
        public ApplicationUser Assessor { get; set; }
        public Maturity Maturity { get; set; }
        public Guid MaturityId { get; set; }
        public ICollection<Score> Scores { get; set; }
        public Guid UserId { get; set; }
        public Guid AssessorId { get; set; }
    }
}

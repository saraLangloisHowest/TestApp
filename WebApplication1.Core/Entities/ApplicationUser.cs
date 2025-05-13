using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Core.Entities
{
    public class ApplicationUser
    {
        public bool IsAssesor { get; set; }
        public bool IsAdmin { get; set; }
        public string UserName { get; set; }
        public ICollection<Assessment> AssessmentsAsUser { get; set; }
        public ICollection<Assessment> AssessmentsAsAssessor { get; set; }
    }
}

using WebApplication1.Core.Entities;

namespace WebApplication1.ViewModels
{
    public class SurveyIndexViewModel
    {
        public string Municipality { get; set; }
        public Guid MunicipalityId { get; set; }
        public string User { get; set; }
        public string Assessor { get; set; }
        public string Maturity { get; set; }

        public IEnumerable<BaseDescriptionViewModel> Functions { get; set; }
        public Guid AssessmentId { get; internal set; }
    }
}

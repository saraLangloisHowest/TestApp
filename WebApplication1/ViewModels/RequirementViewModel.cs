
namespace WebApplication1.ViewModels
{
    public class RequirementViewModel : BaseDescriptionViewModel
    {
        public ScoreViewModel Score { get; set; }
        public IEnumerable<GuidanceViewModel> Guidances { get; set; }
    }
}

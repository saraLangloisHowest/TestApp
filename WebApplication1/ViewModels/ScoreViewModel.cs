

namespace WebApplication1.ViewModels
{
    public class ScoreViewModel
    {

        public int DocumentationMaturityScore { get; set; }
        public int ImplementationMaturityScore { get; set; }

        public string? AdditionalInfo { get; set; }
        public string? AssessorComment { get; set; }
    }
}

namespace WebApplication1.ViewModels
{
    public class SurveyGetCategoriesViewModel
    {
        public Guid UserId { get; set; }
        public Guid FunctionId { get; set; }
        public IEnumerable<BaseDescriptionViewModel> Categories { get; set; }
    }
}

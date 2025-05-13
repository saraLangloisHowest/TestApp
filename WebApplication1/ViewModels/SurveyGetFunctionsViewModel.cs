namespace WebApplication1.ViewModels
{
    public class SurveyGetFunctionsViewModel
    {
        public Guid UserId {  get; set; }
        public IEnumerable<BaseDescriptionViewModel> Functions {  get; set; }
    }
}

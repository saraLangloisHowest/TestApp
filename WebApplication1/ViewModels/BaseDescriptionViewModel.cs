namespace WebApplication1.ViewModels
{
    public class BaseDescriptionViewModel : BaseViewModel
    {
        public string Description { get; set; }
        public string? Color { get; set; }

        public IEnumerable<BaseDescriptionViewModel>? Children { get; set; }
    }
}

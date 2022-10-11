using BookAppSolution.Infrastructure;

namespace BookAppSolution.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public IPage CurrentPageViewModel { get; set; }

        public MainWindowViewModel()
        {
            CurrentPageViewModel = new BooksViewModel();
        }
    }
}

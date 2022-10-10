using BookAppSolution.Infrastructure;
using BookAppSolution.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BookAppSolution.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ObservableCollection<Book> Books { get; set; }

        public Book SelectedBook { get; set; }

        public ICommand CreateNewBookCommand { get; set; }
            
        public ICommand UpdateBookCommand { get; set; }

        public ICommand DeleteBookCommand { get; set; }

        public MainWindowViewModel()
        {
            CreateNewBookCommand = new RelayCommand(CreateNewBook);
            UpdateBookCommand = new RelayCommand(UpdateBook);
            DeleteBookCommand = new RelayCommand(DeleteBook);

            Books = new ObservableCollection<Book>();


        }

        public void CreateNewBook(object obj)
        {

        }

        public void UpdateBook(object obj)
        {

        }

        public void DeleteBook(object obj)
        {

        }
    }
}

using BookAppSolution.BookService;
using BookAppSolution.Infrastructure;
using BookAppSolution.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace BookAppSolution.ViewModels
{
    /// <summary>
    /// Модель представления для книг
    /// </summary>
    public class BooksViewModel : BaseViewModel, IPage
    {
        private readonly IDialogService _dialogService;

        private readonly IErrorMessageBoxService _messageBoxService;

        public string Name { get; set; } = "Книги";

        /// <summary>
        /// Список книг для вывода
        /// </summary>
        public ObservableCollection<Book> Books { get; set; }

        /// <summary>
        /// Выбранная книга в списке
        /// </summary>
        public Book SelectedBook { get; set; }

        /// <summary>
        /// Книга для добавления в базу
        /// </summary>
        public Book NewBook { get; set; }

        /// <summary>
        /// Книга для изменения
        /// </summary>
        public Book CopyBook { get; set; }

        /// <summary>
        /// Переключение видимости окна создания новой книги
        /// </summary>
        public ICommand SwichVisibleCreateNewBookCommand { get; set; }

        /// <summary>
        /// Переключение видимости окна редактирования книги
        /// </summary>
        public ICommand SwichVisibleUpdateBookCommand { get; set; }

        /// <summary>
        /// Команда для удаления книги
        /// </summary>
        public ICommand DeleteBookCommand { get; set; }

        /// <summary>
        /// Команда для создания книги
        /// </summary>
        public ICommand CreateBookCommand { get; set; }

        /// <summary>
        /// Команда для обновления информации о книге
        /// </summary>
        public ICommand UpdateBookCommand { get; set; }

        /// <summary>
        /// Команда для выбора обложки
        /// </summary>
        public ICommand SelectPhotoCommand { get; set; }

        /// <summary>
        /// Видимость окна создания книги
        /// </summary>
        public bool IsVisibleNewBookMenu { get; set; }

        /// <summary>
        /// Видимость окна изменения информации о книге
        /// </summary>
        public bool IsVisibleEditBookMenu { get; set; }

        public BooksViewModel()
        {
            SwichVisibleCreateNewBookCommand = new RelayCommand(SwichVisibleCreateNewBook);
            SwichVisibleUpdateBookCommand = new RelayCommand(SwichVisibleUpdateBook);
            DeleteBookCommand = new RelayCommand(DeleteBook);
            CreateBookCommand = new RelayCommand(CreateBook);
            UpdateBookCommand = new RelayCommand(UpdateBook);
            SelectPhotoCommand = new RelayCommand(SelectPhoto);

            NewBook = new Book();
            SelectedBook = new Book();
            _dialogService = new DialogService();
            _messageBoxService = new MessageBoxService();

            Books = new ObservableCollection<Book>(GetBooks());
        }

        public void SwichVisibleCreateNewBook(object obj)
        {
            IsVisibleNewBookMenu = !IsVisibleNewBookMenu;

            if (!IsVisibleNewBookMenu)
            {
                NewBook = new Book();
            }
        }

        public void SwichVisibleUpdateBook(object obj)
        {
            IsVisibleEditBookMenu = !IsVisibleEditBookMenu;

            if (IsVisibleNewBookMenu)
            {
                CopyBook = new Book();
            }
            else
            {
                CopyBook = new Book
                {
                    ISBN = SelectedBook.ISBN,
                    Author = SelectedBook.Author,
                    Description = SelectedBook.Description,
                    Id = SelectedBook.Id,
                    Name = SelectedBook.Name,
                    Picture = SelectedBook.Picture,
                    RealeseYear = SelectedBook.RealeseYear
                };
            }
        }

        public void DeleteBook(object obj)
        {
            try
            {
                using (var client = new BookServiceClient())
                {
                    client.DeleteBookById(SelectedBook.Id);
                }

                Books.Remove(SelectedBook);
            }
            catch (Exception ex)
            {
                _messageBoxService.OpenMessageBox(ex.Message, "Ошибка");
            }
        }

        public void CreateBook(object obj)
        {
            try
            {
                using (var client = new BookServiceClient())
                {
                    var id = client.CreateNewBook(new BookDto
                    {
                        Author = NewBook.Author,
                        ISBN = NewBook.ISBN,
                        Description = NewBook.Description,
                        Name = NewBook.Name,
                        RealeseYear = NewBook.RealeseYear,
                        Picture = NewBook.Picture
                    });

                    NewBook.Id = id;
                    Books.Add(NewBook);
                }

                NewBook = new Book();
                SwichVisibleCreateNewBook(null);
            }
            catch (Exception ex)
            {
                _messageBoxService.OpenMessageBox(ex.Message, "Ошибка");
            }
        }

        public void UpdateBook(object obj)
        {
            try
            {
                using (var client = new BookServiceClient())
                {
                    client.UpdateBook(new BookDto
                    {
                        Id = CopyBook.Id,
                        Author = CopyBook.Author,
                        ISBN = CopyBook.ISBN,
                        Description = CopyBook.Description,
                        Name = CopyBook.Name,
                        RealeseYear = CopyBook.RealeseYear,
                        Picture = CopyBook.Picture
                    });
                }

                SwichVisibleUpdateBook(null);

                Books = new ObservableCollection<Book>(GetBooks());
            }
            catch (Exception ex)
            {
                _messageBoxService.OpenMessageBox(ex.Message, "Ошибка");
            }
        }

        public void SelectPhoto(object obj)
        {
            //Как вариант использовать сетевой путь т.к. клиент серверное приложение
            var photoPath = _dialogService.OpenFileDialog();

            if (IsVisibleNewBookMenu)
                NewBook.Picture = photoPath;
            else if (IsVisibleEditBookMenu)
                CopyBook.Picture = photoPath;
        }

        private List<Book> GetBooks()
        {
            try
            {
                using (var client = new BookServiceClient())
                {
                    return client.GetBooks().Select(x => new Book
                    {
                        ISBN = x.ISBN,
                        Author = x.Author,
                        Description = x.Description,
                        Id = x.Id,
                        Name = x.Name,
                        Picture = x.Picture,
                        RealeseYear = x.RealeseYear
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                _messageBoxService.OpenMessageBox(ex.Message, "Ошибка");

                return new List<Book>();
            }
        }
    }
}

using BookServices.DTOs;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookServices
{
    public class BookService : IBookService
    {
        public int CreateNewBook(BookDto book)
        {
            using (var context = new BookContext())
            {
                var newBook = new Book
                {
                    Name = book.Name,
                    ISBN = book.ISBN,
                    Author = book.Author,
                    Description = book.Description,
                    Picture = book.Picture,
                    RealeseYear = book.RealeseYear
                };

                context.Books.Add(newBook);

                context.SaveChanges();

                return newBook.Id;
            }
        }

        public void DeleteBookById(int id)
        {
            using (var context = new BookContext())
            {
                var selectedBook = context.Books.FirstOrDefault(x => x.Id == id);

                context.Books.Remove(selectedBook);

                context.SaveChanges();
            }
        }

        public BookDto GetBookById(int id)
        {
            using (var context = new BookContext())
            {
                var selectedBook = context.Books.FirstOrDefault(x => x.Id == id);

                return new BookDto
                {
                    ISBN = selectedBook.ISBN,
                    Id = selectedBook.Id,
                    Author = selectedBook.Author,
                    Description = selectedBook.Description,
                    Name = selectedBook.Name,
                    Picture = selectedBook.Picture,
                    RealeseYear = selectedBook.RealeseYear
                };
            }
        }

        public IEnumerable<BookDto> GetBooks()
        {
            using (var context = new BookContext())
            {
                return context.Books.ToList().Select(x => new BookDto
                {
                    Author = x.Author,
                    ISBN = x.ISBN,
                    Description = x.Description,
                    Id = x.Id,
                    Name = x.Name,
                    Picture = x.Picture,
                    RealeseYear = x.RealeseYear
                });
            }
        }

        public void UpdateBook(BookDto book)
        {
            using (var context = new BookContext())
            {
                var selectedBook = context.Books.FirstOrDefault(x => x.Id == book.Id);

                selectedBook.ISBN = book.ISBN;
                selectedBook.Name = book.Name;
                selectedBook.Picture = book.Picture;
                selectedBook.RealeseYear = book.RealeseYear;
                selectedBook.Author = book.Author;
                selectedBook.Description = book.Description;

                context.SaveChanges();
            }
        }
    }
}

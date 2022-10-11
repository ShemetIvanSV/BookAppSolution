using BookServices.DTOs;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace BookServices
{
    public class BookService : IBookService
    {
        public int CreateNewBook(BookDto book)
        {
            try
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
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void DeleteBookById(int id)
        {
            try
            {
                using (var context = new BookContext())
                {
                    var selectedBook = context.Books.FirstOrDefault(x => x.Id == id);

                    context.Books.Remove(selectedBook);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<BookDto> GetBooks()
        {
            try
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
            catch(Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdateBook(BookDto book)
        {
            if (book is null)
                throw new FaultException<ArgumentException>(new ArgumentNullException("book"));

            using (var context = new BookContext())
            {
                var selectedBook = context.Books.FirstOrDefault(x => x.Id == book.Id);

                if (selectedBook is null)
                    throw new FaultException<ArgumentException>(new ArgumentException($"Не найдена книга по данному идентификатору - {book.Id}"));

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

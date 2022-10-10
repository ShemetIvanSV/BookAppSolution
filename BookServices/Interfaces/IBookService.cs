using BookServices.DTOs;
using System.Collections.Generic;
using System.ServiceModel;

namespace BookServices
{
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        IEnumerable<BookDto> GetBooks();

        [OperationContract]
        BookDto GetBookById(int id);

        [OperationContract]
        void DeleteBookById(int id);

        [OperationContract]
        int CreateNewBook(BookDto book);

        [OperationContract]
        void UpdateBook(BookDto book);
    }
}

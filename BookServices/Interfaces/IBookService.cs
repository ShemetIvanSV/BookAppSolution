using BookServices.DTOs;
using System.Collections.Generic;
using System.ServiceModel;

namespace BookServices
{
    [ServiceContract]
    public interface IBookService
    {
        /// <summary>
        /// Получить весь список книг
        /// </summary>
        /// <returns>Список книг</returns>
        [OperationContract]
        IEnumerable<BookDto> GetBooks();

        /// <summary>
        /// Удаление книги по идентификатору
        /// </summary>
        /// <param name="id">id книги</param>
        [OperationContract]
        void DeleteBookById(int id);

        /// <summary>
        /// Создание новой книги
        /// </summary>
        /// <param name="book">Объект книги для добавления в базу</param>
        /// <returns>Идентификатор новой книги</returns>
        [OperationContract]
        int CreateNewBook(BookDto book);

        /// <summary>
        /// Обновление данных о книге
        /// </summary>
        /// <param name="book">Данные для обновления</param>
        [OperationContract]
        void UpdateBook(BookDto book);
    }
}

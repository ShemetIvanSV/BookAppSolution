using System;

namespace DataAccessLibrary.Models
{
    /// <summary>
    /// Сущность книги
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Автор
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Год выпуска
        /// </summary>
        public string RealeseYear { get; set; }

        /// <summary>
        /// Штрихкод
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Обложка
        /// </summary>
        public string Picture { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}

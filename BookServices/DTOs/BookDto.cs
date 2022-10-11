using System;
using System.Runtime.Serialization;

namespace BookServices.DTOs
{
    /// <summary>
    /// Объект передачи данных о книге
    /// </summary>
    [DataContract]
    public class BookDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Автор
        /// </summary>
        [DataMember]
        public string Author { get; set; }

        /// <summary>
        /// Год выпуска
        /// </summary>
        [DataMember]
        public string RealeseYear { get; set; }

        /// <summary>
        /// Штрихкод
        /// </summary>
        [DataMember]
        public string ISBN { get; set; }

        /// <summary>
        /// Обложка
        /// </summary>
        [DataMember]
        public string Picture { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        [DataMember]
        public string Description { get; set; }
    }
}
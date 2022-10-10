using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace DataAccessLibrary
{
    public class BookContext : DbContext
    {
        public BookContext() : base("BookDbConnection")
        { }

        public DbSet<Book> Books { get; set; }
    }

    //TODO: добавить тестовые данные 
    public class EntitiesContextInitializer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var books = new List<Book>
            {
                new Book {Id=1, Name="Война и мир", Author = "Л.Н. Толстой", Description = "Тестовое описание Война и мир", ISBN = "9781234567897"},
                new Book {Id=2, Name="Ведьмак \"меч предназначения\"", Author = "А. Сапковский", Description = "Тестовое описание Ведьмак \"меч предназначения\"", ISBN = "934534567897"},
                new Book {Id=3, Name="Над пропастью во ржи", Author = "Д.Д. Сэлинджер", Description = "Тестовое описание Над пропастью во ржи", ISBN = "6734555467897"}
            };

            foreach (var book in books)
            {
                context.Books.Add(book);
            }

            context.SaveChanges();
        }
    }
}

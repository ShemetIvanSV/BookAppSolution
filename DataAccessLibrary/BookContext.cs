using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DataAccessLibrary
{
    public class BookContext : DbContext
    {
        public BookContext() : base("BookDbConnection")
        {
            Database.SetInitializer(new EntitiesContextInitializer());
        }

        public DbSet<Book> Books { get; set; }
    }

    public class EntitiesContextInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var picturePath = AppDomain.CurrentDomain.BaseDirectory + "Pictures";

            var books = new List<Book>
            {
                new Book {Id=1, Name="Война и мир", Author = "Л.Н. Толстой", Description = "Тестовое описание Война и мир", ISBN = "9781234567897", RealeseYear ="1865", Picture = picturePath + "\\warandpiece.jpg"},
                new Book {Id=2, Name="Ведьмак \"меч предназначения\"", Author = "А. Сапковский", Description = "Тестовое описание Ведьмак \"меч предназначения\"", ISBN = "934534567897", RealeseYear ="1992", Picture = picturePath + "\\wicher.jpg"},
                new Book {Id=3, Name="Над пропастью во ржи", Author = "Д.Д. Сэлинджер", Description = "Тестовое описание Над пропастью во ржи", ISBN = "6734555467897", RealeseYear = "1951", Picture = picturePath + "\\The_Catcher_in_the_Rye.jpg"},
                new Book {Id=4, Name="Искусство и кофе", Author = "Т.Т. Тестова", Description = "Тестовое описание ", ISBN = "9781234567897", RealeseYear = "2012", Picture = picturePath +"\\coffe.jpg"},
                new Book {Id=5, Name="Continuous Delivery", Author = "", Description = "Тестовое описание", ISBN = "9781234567897", RealeseYear = "1999", Picture = picturePath + "\\1.jpg" },
                new Book {Id=6, Name="Сонная Лощина", Author = "Ирвинг Вашингтон", Description = "Тестовое описание", ISBN = "4353453453534", RealeseYear = "1954", Picture = picturePath + "\\10519_355539.jpg" },
                new Book {Id=7, Name="Братья Карамазовы", Author = "Достоевский Федор Михайлович", Description = "Тестовое описание", ISBN = "546456546546", RealeseYear = "1899", Picture = picturePath + "\\dostoevskiy-bratja-karamazovy.jpg" },
                new Book {Id=8, Name="Процесс", Author = "Кафка Франц", Description = "Тестовое описание", ISBN = "5675675654645", RealeseYear = "1934", Picture = picturePath + "\\процесс.jpg" },
                new Book {Id=9, Name="1984. Скотный двор", Author = "Оруэлл", Description = "Тестовое описание", ISBN = "6785464564564", RealeseYear = "1960", Picture = picturePath + "\\home.jpg"}
            };

            foreach (var book in books)
            {
                context.Books.Add(book);
            }

            context.SaveChanges();
        }
    }
}

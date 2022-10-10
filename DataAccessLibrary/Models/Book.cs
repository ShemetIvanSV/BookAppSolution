using System;

namespace DataAccessLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public DateTime RealeseYear { get; set; }

        public string ISBN { get; set; }

        public byte[] Picture { get; set; }

        public string Description { get; set; }
    }
}

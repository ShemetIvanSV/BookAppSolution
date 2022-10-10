using System;
using System.Runtime.Serialization;

namespace BookServices.DTOs
{
    [DataContract]
    public class BookDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Author { get; set; }

        [DataMember]
        public DateTime RealeseYear { get; set; }

        [DataMember]
        public string ISBN { get; set; }

        [DataMember]
        public byte[] Picture { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
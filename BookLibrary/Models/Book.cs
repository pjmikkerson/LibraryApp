﻿namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public int PublicationYear { get; set; } = 0;
        public bool IsRead { get; set; } = false;
        public string? RecommendedBy { get;  set; }

        public Book()
        {

        }
    }
}

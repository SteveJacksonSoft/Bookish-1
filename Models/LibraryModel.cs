﻿namespace Bookish.Models
{
    public class LibraryModel
    {
        public class Books
        {
            public int BooksId { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string PublishedYear { get; set; }
        }
        
    }
}
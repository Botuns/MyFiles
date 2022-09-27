using System.Collections.Generic;

namespace E_Library.Models
{
    public class AuthorBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book book { get; set; }
        public int AuthorId { get; set; }
        public Author author { get; set; }

    }
}

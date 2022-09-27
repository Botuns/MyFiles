using System.Collections.Generic;

namespace E_Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Isbn { get; set; }
        public int CategoryId { get; set; }
        public BookCategory BookCategory { get; set; }

        public ICollection<AuthorBook> Allauthors { get; set; } = new List<AuthorBook>();
    }
}

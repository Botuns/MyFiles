using System.Collections.Generic;

namespace E_Library.Models
{
    public class BookCategory
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public List<Book> Books { get; set; }
    }
}

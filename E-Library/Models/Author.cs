using System.Collections.Generic;

namespace E_Library.Models

{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public ICollection<AuthorBook> AuthorBooks { get; set; } = new List<AuthorBook>();


    }
}

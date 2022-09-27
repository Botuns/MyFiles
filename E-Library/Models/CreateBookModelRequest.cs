using System.Collections.Generic;

namespace E_Library.Models
{
    public class CreateBookModelRequest
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public int CategoryId { get; set; }
        public string BookCategoryId { get; set; }
        public BookCategory BookCategory { get; set; }
        public int AuthorId { get; set; }

        public IList<int> AuthorIds;

        
            
        
        
    }
}

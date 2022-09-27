using E_Library.Models;
using System.Collections.Generic;

namespace E_Library.Repository
{
    public interface IAuthorRepository
    {
        public void AddAuthor(Author author);
        public ICollection<Author> GetAllAuthors();
    }
}

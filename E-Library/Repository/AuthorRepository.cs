using E_Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace E_Library.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        public readonly ApplicationContext _context;
        public AuthorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void AddAuthor(Author author)
        {
            var newauthor = new Author
            {
                AuthorName = author.AuthorName,
            };
            _context.Authors.Add(newauthor);
            _context.SaveChanges();
        }
        public ICollection<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }
    }
}

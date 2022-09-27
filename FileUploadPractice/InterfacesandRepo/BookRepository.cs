using FileUploadPractice.Contexts;
using FileUploadPractice.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FileUploadPractice.InterfacesandRepo
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationContext _context;
        public BookRepository(ApplicationContext context)
        {
            _context = context;
        }
        public bool AddBooks(Book book)
        {
            var newbook = new Book
            {
                BookName = book.BookName,
                Picture = book.Picture,
            };
            _context.Add(newbook);
            _context.SaveChanges();
            return true;
            
        }

        public IList<Book> GetAllBooks()
        {
            var books = _context.Books.ToList();
            return books;
            
        }

        public Book GetBookById(int id)
        {
            var book = _context.Books.Where(x => x.Id.Equals(id)).FirstOrDefault();
            return book;
        }

        public bool UpdateBooks(int bookId,Book book)
        {
            var Dbook = _context.Books.Where(x => x.Id.Equals(bookId)).FirstOrDefault();
            if (Dbook != null)
            {
                Dbook.BookName = book.BookName;
                Dbook.Picture = book.Picture;   
            }
            _context.Update(Dbook);
            _context.SaveChanges();
            return true;
            
        }
    }
}

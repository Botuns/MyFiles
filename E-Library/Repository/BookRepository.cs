using E_Library.Controllers;
using E_Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace E_Library.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationContext _context;
        public BookRepository(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

        public void CreateBook(CreateBookModelRequest request)
        {
            var book = new Book
            {
                Id = request.Id,
                BookName = request.BookName,
                Isbn = request.Isbn,
                CategoryId = request.CategoryId,
                

            };
            _context.Books.Add(book);
            _context.SaveChanges();
            var authors = _context.Authors.Where(x => request.AuthorIds.Contains(x.Id)).ToList();
            foreach (var author in authors)
            {
                var MyBookAuthor = new Author
                {
                    Id = author.Id,
                    AuthorName = author.AuthorName,

                };
                _context.Authors.Add(MyBookAuthor);
            }
        }

            public void DeleteBook(int Id)
            {
                var book = _context.Books.Find(Id);
                _context.Books.Remove(book);
                _context.SaveChanges();
            }

            public List<Book> GetAllBooks()
            {
                return _context.Books.ToList();
            }

            public Book GetBook(int Id)
            {
                var books = _context.Books.Find(Id);
                return books;
            }



            //public List<Book> GetBooksByCategory(int BookCategoryId)
            //{
            //    var books = _context.Books.Where(book => book.BookCategoryId == BookCategoryId).ToList(); ;
            //    return books;
            //}

            public void UpdateBook(int Id)
            {
                var books = _context.Update(Id);
                _context.SaveChanges();
            }
        }
    }


using E_Library.Controllers;
using E_Library.Models;
using System.Collections.Generic;

namespace E_Library.Repository
{
    public interface IBookRepository
    {

        public void CreateBook(CreateBookModelRequest request);
        public void UpdateBook(int Id);
        public Book GetBook(int Id);
        public List<Book> GetAllBooks();
       // public List<Book> GetBooksByCategory(int BookCategoryId);
        public void DeleteBook(int Id);
        
    }
}

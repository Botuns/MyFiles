using FileUploadPractice.Entities;
using System.Collections.Generic;

namespace FileUploadPractice.InterfacesandRepo
{
    public interface IBookRepository
    {
        bool AddBooks(Book book);
        Book GetBookById(int id);
        IList<Book> GetAllBooks();
        bool UpdateBooks(int bookId, Book book);
    }
}

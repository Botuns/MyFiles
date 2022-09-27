using E_Library.Models;
using E_Library.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace E_Library.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookrepository;
        private readonly IBookCategoryRepository _bookcatrepository;
        private readonly IAuthorRepository _authorrepository;
        public BookController(IBookRepository bookRepository ,IBookCategoryRepository bookCategoryRepository , IAuthorRepository authorRepository)
        {
            _bookrepository = bookRepository;
            _bookcatrepository = bookCategoryRepository;
            _authorrepository = authorRepository;

        }
        public IActionResult BookPage()
        {
            var books = _bookrepository.GetAllBooks();
            return View();
        }
        public string WelcomePage()
        {
            return ("WELCOME TO MY APP");
        }
        public IActionResult AddBook()
        {
            var AllAuthors = _authorrepository.GetAllAuthors();
            ViewData["AllAuthors"] = new SelectList(AllAuthors, "Id", "AuthorName");
            var category = _bookcatrepository.GetAllCategory();
            ViewData["Category"] = new SelectList(category, "Id", "Category");
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(CreateBookModelRequest request)
        {
            _bookrepository.CreateBook(request);
            return View();
        }
        //public  IActionResult  BooksByCategory(int BookCategoryId)
        //{
        //    _bookrepository.GetBooksByCategory(BookCategoryId);
        //    return View();
        //}
        public IActionResult UpdateBook(int Id)
        {
            _bookrepository.UpdateBook(Id);
            return View();
        }
        public IActionResult DeleteBook(int Id)
        {
            _bookcatrepository.DeleteCategory(Id);
            return View();
        }
    }
}

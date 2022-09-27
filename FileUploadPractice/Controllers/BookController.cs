using FileUploadPractice.Entities;
using FileUploadPractice.InterfacesandRepo;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace FileUploadPractice.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public IWebHostEnvironment _webHostEnviroment;
        public BookController(IBookRepository bookRepository, IWebHostEnvironment webHostEnviroment)
        {
            _bookRepository = bookRepository;
            _webHostEnviroment = webHostEnviroment;

        }
        // GET: BookController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookController/Create
        public ActionResult AddBooks()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddBooks(Book book,IFormFile file)
        {
            if (book != null)
            {
                string fileDirectory = Path.Combine(_webHostEnviroment.WebRootPath, "files");
                Directory.CreateDirectory(fileDirectory);
                string ContentType = file.ContentType.Split('/')[1];
                string fileName = $"{Guid.NewGuid()}.{ContentType}";
                string fullPath = Path.Combine(fileDirectory, fileName);
                using (var fileStream = new FileStream(fullPath,FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                book.Picture = fullPath;
            }
             _bookRepository.AddBooks(book);
            return RedirectToAction("AllBooks");
        }

        // GET: BookController/Edit/5
        public ActionResult UpdateBooks()
        {
            return View();
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateBooks(int id, Book book)
        {
            _bookRepository.UpdateBooks(id,book);
            return RedirectToAction("Index");

        }

        // GET: BookController/Delete/5
        public ActionResult AllBooks()
        {
            var books =_bookRepository.GetAllBooks();
            return View(books);
        }
    }
}

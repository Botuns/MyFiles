using E_Library.Models;
using E_Library.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_Library.Controllers
{
    public class BookCategoryController : Controller
    {
        private readonly IBookCategoryRepository _bookcatrepository;
        public BookCategoryController(IBookCategoryRepository bookcatRepository)
        {
            _bookcatrepository = bookcatRepository;
        }
        public IActionResult CreateCategory(BookCategory categorys)
        {
            _bookcatrepository.CreateCategory(categorys);
            return View();
        }

    }
}

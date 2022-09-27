using E_Library.Controllers;
using E_Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace E_Library.Repository
{
    public class BookCategoryRepository : IBookCategoryRepository
    {
        private readonly ApplicationContext _context;
        public BookCategoryRepository(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }
        public void CreateCategory(BookCategory category)
        {
            var categories = new BookCategory
            {
                Category = category.Category, 
            };
            _context.BookCategories.Add(categories);
            _context.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            var category = _context.BookCategories.Find(id);
            _context.BookCategories.Remove(category);
            _context.SaveChanges();
        }

        public List<BookCategory> GetAllCategory()
        {
            var categorys = _context.BookCategories.ToList();
            return categorys;
        }

        public BookCategory GetCategory(int Id)
        {
            var category = _context.BookCategories.Find(Id);
            return category;
        }
    }
}

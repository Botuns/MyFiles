using E_Library.Controllers;
using E_Library.Models;
using System.Collections.Generic;

namespace E_Library.Repository
{
    public interface IBookCategoryRepository
    {
        public void CreateCategory(BookCategory category);
        public BookCategory GetCategory(int Id);
        public List<BookCategory> GetAllCategory();
        public void DeleteCategory(int id);
    }
}

using System;
using E_Library.Controllers;
using E_Library.Models;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;
namespace E_Library
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL("server=localhost;database=BookManagers;user=root;password=OLADOL123");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<CreateBookModelRequest> CreateBookModels { get; set; }
    }
}


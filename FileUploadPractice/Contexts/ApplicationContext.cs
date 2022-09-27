using FileUploadPractice.Entities;
using Microsoft.EntityFrameworkCore;

namespace FileUploadPractice.Contexts
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;user=root;database=FileUpload;port=3306;password=OLADOL123");


        }
        public DbSet<Book>Books { get; set; }
    }
}

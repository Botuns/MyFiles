using Authentication.Entities;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Contexts
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> optionsBuilder) : base(optionsBuilder)
        {
 
        }
        public DbSet<User>Users { get; set; }
    }
}

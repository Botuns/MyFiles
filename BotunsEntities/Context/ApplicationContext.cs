using BotunsEntities.Entities;
using BotunsEntities.Identity;
using Microsoft.EntityFrameworkCore;

namespace BotunsEntities.Context
{
    
        public class ApplicationContext : DbContext
        {
            public ApplicationContext(DbContextOptions<ApplicationContext> options)
             : base(options)
            {

            }
            public DbSet<Admin>? Admins { get; set; }
            public DbSet<Address>? Address { get; set; }
            public DbSet<Client>? Clients { get; set; }
            public DbSet<ProjectManager>? ProjectManagers { get; set; }
            public DbSet<CompanyPersonnel>? CompanyPersonnels { get; set; }
            public DbSet<Contract>? Contracts { get; set; }
            public DbSet<ClientContract>? ClientContracts { get; set; }
            public DbSet<ClientProjectManager>? ClientProjectManagers { get; set; }
            public DbSet<Payment>? Payments { get; set; }
            public DbSet<Complaint>? Complaints { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<UserRole>? UserRoles { get; set; }



    }
    
}

using BotunsEngineeringServices.Entities;
using Microsoft.EntityFrameworkCore;

namespace BotunsEngineeringServices.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientContracts> ClientContracts { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<WorkerClient> WorkerClients { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

    }
}

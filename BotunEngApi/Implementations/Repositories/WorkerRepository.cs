using BotunsEngApi.Contexts;
using BotunsEngApi.Entities;
using BotunsEngApi.Interfaces.Repositories;
using System.Linq;

namespace BotunsEngApi.Implementations.Repositories
{
    public class WorkerRepository : IWorkerRepository
    {
        private readonly ApplicationContext _context;
        public WorkerRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Worker CreateWorker(Worker worker)
        {
            _context.Workers.Add(worker);
            _context.SaveChanges();
            return worker;
        }

        public void DeleteWorker(int Id)
        {
            var worker = _context.Workers.Where(x => x.Id.Equals(Id)).FirstOrDefault();
            _context.Workers.Remove(worker);
            _context.SaveChanges();

        }

        public Worker GetWorkerByEmailandPassword(string email, string password)
        {
            var worker = _context.Workers.SingleOrDefault(x => x.Email.Equals(email) && x.Password.Equals(password));
            return worker;
        }

        public Worker GetWorkerById(int Id)
        {
            var worker = _context.Workers.Where(x => x.Id == Id).FirstOrDefault();
            return worker;
        }

        public Worker UpdateWorker(Worker worker)
        {
            _context.Workers.Update(worker);
            _context.SaveChanges();
            return worker;
        }
    }
}

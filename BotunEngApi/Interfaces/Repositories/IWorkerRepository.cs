using BotunsEngApi.Entities;

namespace BotunsEngApi.Interfaces.Repositories
{
    public interface IWorkerRepository
    {
        public Worker CreateWorker(Worker worker);
        public Worker UpdateWorker(Worker worker);
        public void DeleteWorker(int Id);
        public Worker GetWorkerByEmailandPassword(string email, string password);
        public Worker GetWorkerById(int Id);
    }
}

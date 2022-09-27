using BotunsEngApi.DTOs;
using BotunsEngApi.DTOs.WorkerDTO;
using BotunsEngApi.Entities;

namespace BotunEngApi.Interfaces.Services
{
    public interface IWorkerServices
    {
        public BaseResponseModel<Worker> CreateWorker(WorkerRequestModel request);
        public BaseResponseModel<Worker> UpdateWorker(WorkerRequestModel request);
        public BaseResponseModel<Worker> DeleteWorker(int Id);
        public BaseResponseModel<Worker> GetWorkerByEmailandPassword(string email, string password);
        public BaseResponseModel<Worker> GetWorkerById(int Id);
    }
}

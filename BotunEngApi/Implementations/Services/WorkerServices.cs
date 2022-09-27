using BotunEngApi.Interfaces.Services;
using BotunsEngApi.Contexts;
using BotunsEngApi.DTOs;
using BotunsEngApi.DTOs.WorkerDTO;
using BotunsEngApi.Entities;
using BotunsEngApi.Implementations.Repositories;
using BotunsEngApi.Interfaces.Repositories;
using System;

namespace BotunEngApi.Implementations.Services
{
    public class WorkerServices : IWorkerServices
    {
        private readonly ApplicationContext _context;
        public AddressRepository _addressRepository;
        public IWorkerRepository _workerRepository;
        public WorkerServices(ApplicationContext context, AddressRepository addressRepository, IWorkerRepository workerRepository)
        {
            _context = context;
            _addressRepository = addressRepository;
            _workerRepository = workerRepository;
        }
        public BaseResponseModel<Worker> CreateWorker(WorkerRequestModel request)
        {
            var worker = _workerRepository.GetWorkerByEmailandPassword(request.Email, request.Password);
            
            if(worker != null)
            {
                return new BaseResponseModel<Worker>
                {
                    IsSuccess = false,
                    Message = "Worker Already Exists "
                    
                };

            }
            else
            {
                Address address = new Address
                {
                    Country = request.Country,
                    State = request.State,
                    Town = request.Town,
                    LocalGovernment = request.LocalGovernment,
                };
                _addressRepository.CreateAddres(address);
                Worker worker1 = new Worker
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    Password = request.Password,
                    WorkerRefNo = Guid(request.Id, request.LastName),
                    //WorkerType = request.WorkerRefNo,
                    AddressId = request.Id,
                    Address = address,
                };
                _workerRepository.CreateWorker(worker1);
            }
            return new BaseResponseModel<Worker>
            {
                Data = new Worker
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    Password = request.Password,
                    WorkerRefNo = Guid(request.Id, request.LastName),
                    //WorkerType = request.WorkerRefNo,
                },
                IsSuccess = true,
                Message = "Worker Sucessfully Created !"
            };
        }

        private string Guid(int v1, string v2)
        {
            return $"{v1}{v2}";
        }

        public BaseResponseModel<Worker> DeleteWorker(int Id)
        {
            throw new System.NotImplementedException();
        }

        public BaseResponseModel<Worker> GetWorkerByEmailandPassword(string email, string password)
        {
            throw new System.NotImplementedException();
        }

        public BaseResponseModel<Worker> GetWorkerById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public BaseResponseModel<Worker> UpdateWorker(WorkerRequestModel request)
        {
            throw new System.NotImplementedException();
        }
    }
}

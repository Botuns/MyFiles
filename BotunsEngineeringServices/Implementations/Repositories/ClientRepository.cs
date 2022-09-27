using BotunsEngineeringServices.Contexts;
using BotunsEngineeringServices.DTOs.ContractDTO;
using BotunsEngineeringServices.DTOs.WorkerDTO;
using BotunsEngineeringServices.Entities;
using BotunsEngineeringServices.Interfaces.Repositories;
using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BotunsEngineeringServices.Implementations.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationContext _context;
        public AddressRepository _addressRepository;
        public ClientRepository(ApplicationContext context, AddressRepository addressRepository)
        {
            _context = context;
            _addressRepository = addressRepository;
        }
        public Client CreateClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
            return client;
        }

        public void DeleteClient(int id)
        {
            var Dclient = _context.Clients.FirstOrDefault(x => x.Id == id);
            _context.Clients.Remove(Dclient);
            _context.SaveChanges();
        }

        public List<WorkerDTO> GetAllClientWorkers(int clientId)
        {
            var clientWorkers = _context.WorkerClients.Include(x => x.Worker).Where(x => x.ClientId == clientId).Select(c => c.Worker).ToList();
            var workers = clientWorkers.Select(a => new WorkerDTO
            {
                FirstName = a.FirstName,
                LastName = a.LastName,
                Address = a.Address,
                Email = a.Email,
                WorkerRefNo = a.WorkerRefNo,
                WorkerType = a.WorkerType,
            }).ToList();
            return workers;
        }

        public Client GetClientByEmailandPassword(string email, string password)
        {
            var client = _context.Clients.Where(x => x.Email.Equals(email) && x.Password.Equals(password)).FirstOrDefault();
            return client;
        }

        public Client GetClientById(int Id)
        {
            var client = _context.Clients.FirstOrDefault(x => x.Id == Id);
            return client;
        }

        public List<ContractDTO> GetClientContracts(int clientId)
        {
            var clientContracts = _context.ClientContracts.Include(y => y.Contract).Where(x => x.ClientId == clientId).Select(c => c.Contract).ToList();
            var contracts = clientContracts.Select(a => new ContractDTO
            {
                ContractDate = a.ContractDate,
                ContractDuration = a.ContractDuration,
                ContractPrice = a.ContractDuration.Seconds * 100,
                HireType = a.HireType,
                ServiceType = a.ServiceType,
                ClientMessage = a.ClientMessage,
                
                
            }).ToList();
            return contracts;
            
        }

        public Client UpdateClient(Client client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
            return client;
        }
    }
}

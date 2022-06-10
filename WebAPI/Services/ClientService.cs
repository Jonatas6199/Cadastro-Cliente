using CadastroPersistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Interfaces.IRepositories;
using WebAPI.Interfaces.IServices;

namespace WebAPI.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
       
        public List<Client> GetClients()
        {
            return _clientRepository.GetClients();
        }
    }
}
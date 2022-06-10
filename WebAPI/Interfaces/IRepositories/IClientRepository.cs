using CadastroPersistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Interfaces.IRepositories
{
    public interface IClientRepository 
    {
        List<Client> GetClients();
    }
}
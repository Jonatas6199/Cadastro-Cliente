using CadastroPersistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Interfaces.IRepositories;

namespace WebAPI.Repository
{
    public class ClientRepository : IClientRepository, IDisposable
    {
        public void Dispose()
        {
            this.Dispose();
        }

        public List<Client> GetClients()
        {
            //This is a mock data for a while
            return new List<Client>
            {
                new Client
                {
                    Id = 1,
                    CPF = "528.416.628-02",
                    DateOfBirth = DateTime.Parse("27/08/1995"),
                    IssuingAgency = "SSP",
                    MaritalStatus = "Casado",
                    Name = "Pedro Rodrigues",
                    RG = "35.786.919-9",
                    Sex = "M",
                    ShippingDate = DateTime.Parse("23/11/2009"),
                    UF = "SP"
                },
                new Client
                {
                    Id = 2,
                    CPF = "505.775.288-07",
                    DateOfBirth = DateTime.Parse("22/10/1993"),
                    IssuingAgency = "SSP",
                    MaritalStatus = "Casado",
                    Name = "Cristina da Silva",
                    RG = "17.474.068-2",
                    Sex = "F",
                    ShippingDate = DateTime.Parse("12/05/2012"),
                    UF = "SP"
                }
            };
        }
    }
}
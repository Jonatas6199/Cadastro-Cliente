﻿using CadastroPersistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Interfaces.IServices
{
    public interface IClientService
    {
        List<Client> GetClients();
    }
}

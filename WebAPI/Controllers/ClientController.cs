using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Interfaces;
using WebAPI.Interfaces.IServices;

namespace WebAPI.Controllers
{
    public class ClientController : ApiController
    {
        public readonly IClientService _clientService;
        public readonly IClientAddressService _clientAddressService;
        public ClientController(IClientService clientService, IClientAddressService clientAddressService)
        {
            _clientService = clientService;
            _clientAddressService = clientAddressService;
        }

        [HttpGet]
        public IHttpActionResult GetClients()
        {
            try
            {
                var clients = _clientService.GetClients();
                return Ok(clients);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}

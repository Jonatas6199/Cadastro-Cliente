using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPersistence.Models
{
    public class ClientAddress
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string CEP { get; set; }
        public string StreetName { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Neighbourhood { get; set; }
        public string City { get; set; }
        public string UF { get; set; }
    }
}

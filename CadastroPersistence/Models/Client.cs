using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPersistence.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Name { get; set; }
        public string RG { get; set; }
        public DateTime ShippingDate { get; set; }// Data da expedição
        public string IssuingAgency { get; set; } //Órgão expedidor
        public string UF { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string MaritalStatus { get; set; } //Estado Civil
    }
}

using AvaliacaoImoveis.Models.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoImoveis.Models.Order
{
    class ServiceOrder
    {
        public int Id { get; set; }
        public string Cod { get; set; }
        public DateTime CreationDate { get; set; }
        public string City { get; set; }
        public double ServicePrice { get; set; }
        public double DisplacementPrice { get; set; }
        public bool Documents { get; set; }
        public double Price()
        {
            return ServicePrice + DisplacementPrice;
        }
    }
}

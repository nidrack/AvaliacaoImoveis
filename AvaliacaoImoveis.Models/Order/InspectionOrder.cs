using AvaliacaoImoveis.Models.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoImoveis.Models.Order
{
    class InspectionOrder : ServiceOrder
    {
        public bool Inspection { get; set; }
        public bool Picture { get; set; }
        public bool Siopi { get; set; }
        public Inspector Inspector { get; set; }
    }
}

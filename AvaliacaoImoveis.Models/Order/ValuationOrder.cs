using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoImoveis.Models.Order
{
    class ValuationOrder : InspectionOrder
    {
        public bool Data { get; set; }
        public bool Model { get; set; }
        public bool Simil { get; set; }
        public bool ResearchRecord { get; set; }
    }
}

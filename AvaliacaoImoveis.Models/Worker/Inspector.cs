using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoImoveis.Models.Worker
{
    class Inspector
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreaNumber { get; set; }

        public Inspector(string name, int creaNumber)
        {
            Name = name;
            CreaNumber = creaNumber;
        }
    }
}

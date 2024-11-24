using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSys.Model
{
    internal class Estoque
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Medicamento { get; set; }
        public int Quantidade { get; set; }

    }
}

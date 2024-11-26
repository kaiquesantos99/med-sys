using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSys.Model
{
    internal class PacienteFiltrado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Nascimento { get; set; }
        public string Status_paciente { get; set; }
    }
}

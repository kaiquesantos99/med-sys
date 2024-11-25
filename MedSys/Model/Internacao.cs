using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSys.Model
{
    internal class Internacao
    {
        public int Atendimento { get; set; }
        public string Paciente {  get; set; }
        public string Cpf {  get; set; }
        public string Nascimento { get; set; }
        public string Sexo {  get; set; }
        public string Leito {  get; set; }
        public string Setor {  get; set; }
        public string InternadoTempo { get; set; }

        public string Medico {  get; set; }
        public string Especialidade {  get; set; }
        public string StatusPaciente { get; set; }


    }
}

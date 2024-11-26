using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MedSys.Model
{
    internal class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Telefone_2 { get; set; }
        public string Acompanhante { get; set; }
        public string Carteirinha { get; set; }
        public string Convenio { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public string Observacoes { get; set; }
        public string Status_Paciente {  get; set; }
        public string Sexo { get; set; }
    }
}

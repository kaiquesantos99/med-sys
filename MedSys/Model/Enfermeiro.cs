using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSys.Model
{
    internal class Enfermeiro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Dt_Admissao { get; set; }
        public int Matricula { get; set; }
        public int Coren { get; set; }
        public string Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public int Pis { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}

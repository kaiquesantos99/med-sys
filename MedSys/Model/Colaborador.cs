﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSys.Model
{
    internal class Colaborador
    {
        public int Id { get; set; }
        public string Usuario { get; set;}
        public string Senha { get; set; }

        public string Nome {  get; set; }
        public string Cpf {  get; set; }
    }
}

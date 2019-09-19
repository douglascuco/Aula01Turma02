﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroPessoas.Model
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public double Altura { get; set; }
        public int RG { get; set; }
        public string CPF { get; set; }
    }
}

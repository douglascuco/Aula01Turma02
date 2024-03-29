﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroDeImoveisCore.Models
{
    public class Imovel : ControleDeUsuario
    {
        [Key]
        public int Id { get; set; }
        public int Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public int IdProprietario { get; set; }
    }
}

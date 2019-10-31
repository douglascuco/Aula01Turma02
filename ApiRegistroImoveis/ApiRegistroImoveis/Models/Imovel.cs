using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiRegistroImoveis.Models
{
    public class Imovel
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
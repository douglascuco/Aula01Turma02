using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroDeImoveisCore.Models
{
    public class Proprietario : ControleDeUsuario
    {
        [Key] 
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNasc { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}

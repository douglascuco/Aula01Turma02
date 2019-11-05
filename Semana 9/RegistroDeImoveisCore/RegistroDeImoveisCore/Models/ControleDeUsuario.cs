using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroDeImoveisCore.Models
{
    public class ControleDeUsuario
    {
        public bool Ativo { get; set; } = true;
        public int UsuInc { get; set; } = 0;
        public int UsuAlt { get; set; } = 0;
        public DateTime DataInc { get; set; } = DateTime.Now;
        public DateTime DataAlt { get; set; } = DateTime.Now;

    }
}

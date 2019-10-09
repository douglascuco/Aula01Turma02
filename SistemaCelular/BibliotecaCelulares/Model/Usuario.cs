using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCelulares.Model
{
    public class Usuario : ControleUsuariocs
     {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Nome { get; set; }
        [MaxLength(50)]
        [Required]
        public string Login { get; set; }
        [MaxLength(50)]
        [Required]
        public string Senha { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCelulares.Model
{
    public class Celular : ControleUsuariocs
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Model { get; set; }
        [MaxLength(30)]
        [Required]
        public string Marca { get; set; }
        [Required]
        public double Preco { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class Usuario : ControleUsuario
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Login { get; set; }
        [MaxLength(30)]
        [Required]
        public string Senha { get; set; }
    }
}

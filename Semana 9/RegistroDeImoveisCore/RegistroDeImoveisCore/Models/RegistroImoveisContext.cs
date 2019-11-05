using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace RegistroDeImoveisCore.Models
{
    public class RegistroImoveisContext : DbContext
    {
        public RegistroImoveisContext(DbContextOptions<RegistroImoveisContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
    }
}

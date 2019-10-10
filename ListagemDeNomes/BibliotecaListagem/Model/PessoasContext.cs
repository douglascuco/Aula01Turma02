using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaListagem.Model
{
    public class PessoasContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

    }
}

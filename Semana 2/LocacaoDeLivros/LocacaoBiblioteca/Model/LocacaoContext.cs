using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        public List<Usuario> ListaUsuarios { get; set; }
        public List<Livro> ListaLivros { get; set; }

        public int IdContadorUser { get; set; } = 1;
        public int IdContadorLivro { get; set; } = 1;

        public LocacaoContext()
        {
            ListaLivros = new List<Livro>();

            ListaLivros.Add(new Livro()
            {
                Id = IdContadorLivro++,
                Nome = "Harry Potter"
            });

            ListaLivros.Add(new Livro()
            {
                Id = IdContadorLivro++,
                Nome = "Os legados de Lorien"
            });

            ListaLivros.Add(new Livro()
            {
                Id = IdContadorLivro++,
                Nome = "O guia do mochileiro"
            });

            ListaLivros.Add(new Livro()
            {
                Id = IdContadorLivro++,
                Nome = "Maze runner"
            });

            ListaUsuarios = new List<Usuario>();

            ListaUsuarios.Add(new Usuario
            {
                Id = IdContadorUser++,
                Login = "admin",
                Senha = "admin"

            });

            ListaUsuarios.Add(new Usuario()
            {
                Id = IdContadorUser++,
                Login = "1",
                Senha = "1"

            });



        }

    }

}
        

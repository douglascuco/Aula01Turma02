using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivroController
    {
        public LivroController()
        {
            Livros = new List<Livro>();
            Livros.Add(new Livro()
            {
                Nome = "Harry Potter"
            });

            Livros.Add(new Livro()
            {
                Nome = "Os legados de Lorien"
            });

            Livros.Add(new Livro()
            {
                Nome = "Maze runner"
            });
        }

        public List<Livro> Livros { get; set; }
    }
}

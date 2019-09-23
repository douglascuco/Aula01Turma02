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

        private List<Livro> Livros { get; set; }

        public LivroController()
        {
            Livros = new List<Livro>();
            Livros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Harry Potter"
            });

            Livros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Os legados de Lorien"
            });

            Livros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Maze runner"
            });
        }

        /// <summary>
        /// Método para adicionar um livro a lista de livros
        /// </summary>
        /// <param name="livro">Informações do livro que serão adicionadas</param>
        public void CadastrarLivro(Livro livro)
        {
            livro.Id = IdContador++;
            Livros.Add(livro);
        }

        /// <summary>
        /// metodo para retornar listra de livros
        /// </summary>
        /// <returns>retorna lista de livros</returns>
        public List<Livro> RetornaListaDeLivros()
        {
            return Livros;
        }

        private int IdContador = 0;
    }
}

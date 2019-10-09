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
        //private List<Livro> ListaLivros { get; set; }

        LocacaoContext contextDB = new LocacaoContext();

        /// <summary>
        /// metodo para retornar listra de livros
        /// </summary>
        /// <returns>retorna lista de livros</returns>
        public IQueryable<Livro> RetornaListaDeLivros()
        {
            return contextDB.ListaLivros.Where(x => x.Ativo == true);
        }

        public IQueryable<Livro> RetornaListaAdmin()
        {
            return contextDB.ListaLivros.Where(x => x.Ativo == false);
        }

        public bool CadastrarLivro(Livro livro)
        {
            if (string.IsNullOrWhiteSpace(livro.Nome))
                return false;

            contextDB.ListaLivros.Add(livro);
            contextDB.SaveChanges();
            return true;
        }

        public bool RemoverLivro(int idLivro)
        {
            var livro = contextDB.ListaLivros.FirstOrDefault(x => x.Id == idLivro);
            if (livro == null)
                return false;

            livro.Ativo = false;
            contextDB.SaveChanges();

            return true;
        }

        public bool AtualizarLivro(Livro item)
        {
            var livro = contextDB.ListaLivros.FirstOrDefault(x => x.Id == item.Id);
            if (livro == null)
                return false;
            else
            {
                item.DataAlteracao = DateTime.Now;
            }
            contextDB.SaveChanges();
            return true;
        }

        public bool ValidaNomeLivroExiste(string nomeLivro)
        {
           return RetornaListaDeLivros().ToList<Livro>().Exists(x => x.Nome == nomeLivro);
        }

    }
}

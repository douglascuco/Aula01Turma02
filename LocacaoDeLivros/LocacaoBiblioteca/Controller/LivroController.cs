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

        LocacaoContext locacaoContext = new LocacaoContext();

        /// <summary>
        /// Método para adicionar um livro a lista de livros
        /// </summary>
        /// <param name="livro">Informações do livro que serão adicionadas</param>
        public void CadastrarLivro(Livro livro)
        {
            livro.Id =  locacaoContext.IdContadorLivro++;
            locacaoContext.ListaLivros.Add(livro);
        }

        /// <summary>
        /// metodo para retornar listra de livros
        /// </summary>
        /// <returns>retorna lista de livros</returns>
        public List<Livro> RetornaListaDeLivros()
        {
            return locacaoContext.ListaLivros.Where(x => x.Ativo == true).ToList<Livro>() ;
        }

        public bool ValidaNomeLivroExiste(string nomeUser)
        {
            return locacaoContext.ListaLivros.Exists(i => i.Nome == nomeUser);
        }

        /// <summary>
        /// remove livro pro id
        /// </summary>
        /// <param name="idUser">o id do livro que deseja ser removido</param>
        public bool RemoverLivroPorId(int idLivro)
        {
            if (locacaoContext.ListaLivros.Exists(i => i.Id == idLivro && i.Ativo == true))
            {
                locacaoContext.ListaLivros.FirstOrDefault(x => x.Id == idLivro).Ativo = false;
                return true;
            }
            else
                return false;
              
        }
    }
}

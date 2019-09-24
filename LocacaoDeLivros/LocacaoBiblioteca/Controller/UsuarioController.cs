using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contem os metodos de usuario do sistema
    /// </summary>
    public class UsuarioController
    {
        LocacaoContext locacaoContext = new LocacaoContext();

        /// <summary>
        /// Metodo para Validar login no sistema
        /// </summary>
        /// <param name="user">Objeto usuario passado como parametro</param>
        /// <returns>retorna 'true' caso a validação correta ou 'false' caso incorreta</returns>
        public bool LoginSistema( Usuario user)
        {
            return RetornaListaDeUsuarios().Exists(i => i.Login == user.Login && i.Senha == user.Senha);
        }

        /// <summary>
        /// Cadastra o usuario inseriodo no sistema
        /// </summary>
        /// <param name="user">Usuario a ser inserido no sistema</param>
        public void CadastrarUser(Usuario user)
        {
            user.Id = locacaoContext.IdContadorUser++;
           locacaoContext.ListaUsuarios.Add(user);
        }

        public bool ValidaNomeExiste(string nomeUser)
        {
            return locacaoContext.ListaUsuarios.Exists(i => i.Login == nomeUser);
        }

        /// <summary>
        /// metodo para retornar usuarios cadastrados
        /// </summary>
        /// <returns>retorna os usuarios ATIVOS cadastrados</returns>
        public List<Usuario> RetornaListaDeUsuarios()
        {
            return locacaoContext.ListaUsuarios.Where(x => x.Ativo).ToList<Usuario>() ;
        }

        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="idUser">Id do usuarios a ser desativado</param>
        public bool RemoverUsuarioPorId(int idUser)
        {

            if (locacaoContext.ListaUsuarios.Exists(i => i.Id == idUser && i.Ativo == true))
            {
                locacaoContext.ListaUsuarios.FirstOrDefault(x => x.Id == idUser).Ativo = false;
                return true;
            }
            else
                return false;
            
        }
    }
}

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
        LocacaoContext contextDB = new LocacaoContext();


        /// <summary>
        /// metodo para retornar usuarios cadastrados
        /// </summary>
        /// <returns>retorna os usuarios ATIVOS cadastrados</returns>
        public IQueryable<Usuario> RetornaListaDeUsuarios()
        {
            return contextDB.ListaUsuarios.Where(x => x.Ativo);
        }

        /// <summary>
        /// Metodo para Validar login no sistema
        /// </summary>
        /// <param name="user">Objeto usuario passado como parametro</param>
        /// <returns>retorna 'true' caso a validação correta ou 'false' caso incorreta</returns>
        public bool LoginSistema( Usuario user)
        {
            return false;
        }

        public bool CadastrarUsuario(Usuario user)
        {
            if (string.IsNullOrWhiteSpace(user.Login))
                return false;
            if (string.IsNullOrWhiteSpace(user.Senha))
                return false;

            contextDB.ListaUsuarios.Add(user);
            contextDB.SaveChanges();
            return true;
        }

        public bool RemoverUsuario(int idUser)
        {
            var usuario = contextDB.ListaUsuarios.FirstOrDefault(x => x.Id == idUser);
            if (usuario == null)
                return false;

            usuario.Ativo = false;
            contextDB.SaveChanges();

            return true;
        }

        public bool AtualizarUsuario(Usuario item)
        {
            var usuario = contextDB.ListaUsuarios.FirstOrDefault(x => x.Id == item.Id);
            if (usuario == null)
                return false;
            else
            {
                item.DataAlteracao = DateTime.Now;
            }
            contextDB.SaveChanges();
            return true;
        }

    }
}

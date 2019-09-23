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
        private List<Usuario> Users { get; set; }

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public UsuarioController()
        {
            Users = new List<Usuario>();
            Users.Add(new Usuario()
            {
                Id = IdContador++,
                Login = "admin",
                Senha = "admin"

            });

            Users.Add(new Usuario()
            {
                Id = IdContador++,
                Login = "1",
                Senha = "1"

            });

        }

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
            user.Id = IdContador++;
            Users.Add(user);
        }

        public bool ValidaNomeExiste(string nomeUser)
        {
            return Users.Exists(i => i.Login == nomeUser);
        }

        private int IdContador = 0;

        /// <summary>
        /// metodo para retornar usuarios cadastrados
        /// </summary>
        /// <returns>retorna os usuarios ATIVOS cadastrados</returns>
        public List<Usuario> RetornaListaDeUsuarios()
        {
            return Users.Where(x => x.Ativo).ToList<Usuario>() ;
        }


        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="idUser">Id do usuarios a ser desativado</param>
        public void RemoverUsuarioPorId(int idUser)
        {
            Users.FirstOrDefault(x => x.Id == idUser).Ativo = false;
        }
    }
}

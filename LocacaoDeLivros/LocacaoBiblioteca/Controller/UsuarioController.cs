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
        public List<Usuario> Users { get; set; }

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public UsuarioController()
        {
            Users = new List<Usuario>();
            Users.Add(new Usuario()
            {
                Login = "admin",
                Senha = "admin"

            });

            Users.Add(new Usuario()
            {
                Login = "Douglas",
                Senha = "123456"

            });

        }

        /// <summary>
        /// Metodo para Validar login no sistema
        /// </summary>
        /// <param name="user">Objeto usuario passado como parametro</param>
        /// <returns>retorna 'true' caso a validação correta ou 'false' caso incorreta</returns>
        public bool LoginSistema( Usuario user)
        {
            return Users.Exists(i => i.Login == user.Login && i.Senha == user.Senha);
        }

    }
}

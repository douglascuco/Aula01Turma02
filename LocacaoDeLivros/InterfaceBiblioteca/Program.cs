using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {
        static LivroController livros = new LivroController();
        static UsuarioController usuarios = new UsuarioController();

        static void Main(string[] args)
        {
            MostraTelaInicial();

            MostraMenuSistema();
        }

        private static void MostraTelaInicial()
        {
            Console.Clear();
            Console.WriteLine("-----SISTEMA DE LOCAÇÂO DE LIVROS-----");
            while (!RealizaLoginSistema())
            {
                Console.Clear();
                Console.WriteLine("Login ou senha incorretos");
            }
        }

        /// <summary>
        /// Mostra todos os usuarios cadastrados
        /// </summary>
        private static void MostrarUsuarios()
        {
            Console.Clear();
            usuarios.Users.ForEach(i => Console.WriteLine(i.Login));
            Console.ReadKey(true);
        }

        /// <summary>
        /// mostra os livros cadastrados
        /// </summary>
        private static void MostrarLivros()
        {
            Console.Clear();
            livros.Livros.ForEach(i => Console.WriteLine(i.Nome));
            Console.ReadKey(true);
        }

        /// <summary>
        /// Mostra o menu do sistema
        /// </summary>
        private static void MostraMenuSistema()
        {
            var validado = 1;
            while (validado != 0)
            {

                Console.Clear();
                Console.WriteLine("-----SISTEMA DE LOCAÇÂO DE LIVROS-----");
                Console.WriteLine("------Menu Sistema-------");
                Console.WriteLine("1 - Listar Usuarios");
                Console.WriteLine("2 - Listar Livro");
                Console.WriteLine("3 - Cadastrar Livro");
                Console.WriteLine("9 - Fazer LogOff");
                Console.WriteLine("0 - Sair ");
                validado = ValidaMenu();


                switch (validado)
                {
                    case 1:
                        //listar usuarios
                        MostrarUsuarios();
                        break;

                    case 2:
                        //mostrar livro
                        MostrarLivros();
                        break;

                    case 9:
                        Console.Clear();
                        while (!RealizaLoginSistema())
                        {
                            Console.Clear();
                            Console.WriteLine("Login ou senha incorretos");
                        }
                        break;

                    default:
                        break;
                }
            }
            /* Aqui vamos pegar numero digitado 
               e executar a proxima função*/
        }

        /// <summary>
        /// Confere se o login e senha informado estão no sistema
        /// </summary>
        /// <returns>retorna 'true' caso esteja ou 'false' caso não esteja</returns>
        private static bool RealizaLoginSistema()
        {
            Console.WriteLine("Informe seu login e senha para acessar o sistema");
            Console.WriteLine("Login: ");
            var loginUser = Console.ReadLine();
            Console.WriteLine("Senha: ");
            var senhaUser = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();

            Usuario user = new Usuario();

            user.Login = loginUser;
            user.Senha = senhaUser;

            return usuarioController.LoginSistema(user); 
        }

        /// <summary>
        /// Valida se a resposta pro menu é um número inteiro, caso não for é pedido novamente o para poder revalidar
        /// </summary>
        /// <param name="respostaMenu">String para validar se é inteiro</param>
        /// <returns>Retorna o numero inteiro</returns>
        private static int ValidaMenu()
        {
            var valido = false;
            int resposta = 0;
            while (!valido)
            {
                if (int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out resposta))
                    valido = true;
                else
                    Console.WriteLine("Digite apenas numeros");
            }
            return resposta;
        }
    }
}

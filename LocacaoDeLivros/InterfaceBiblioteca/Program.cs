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
        static LivroController livrosController = new LivroController();
        static UsuarioController usuariosController = new UsuarioController();

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
            usuariosController.RetornaListaDeUsuarios().ForEach(i => Console.WriteLine($"ID: {i.Id} Login: {i.Login} Ativo: {i.Ativo}"));
            Console.ReadKey(true);
        }

        /// <summary>
        /// mostra os livros cadastrados
        /// </summary>
        private static void MostrarLivros()
        {
            Console.Clear();
            livrosController.RetornaListaDeLivros().ForEach(i => Console.WriteLine($"ID: {i.Id} Nome do livro: {i.Nome}"));
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
                Console.WriteLine("4 - Cadastrar Usuario");
                Console.WriteLine("5 - Remover Usuario");
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

                    case 3:
                        //cadastrar livros
                        CadastrarLivro();
                        break;

                    case 4:
                        //cadastrar livros
                        CadastrarUser();
                        break;
                        
                    case 5:
                        //remover usuario
                        RemoverUsuario();
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
        }

        /// <summary>
        /// Metodo para cadastrar um livro no sistema
        /// </summary>
        private static void CadastrarUser()
        {
            Console.Clear();
            Console.WriteLine("Cadastrar usuario dentro do sistema: ");
            Console.WriteLine("Informe o login: ");

            var nomeDoUsuario = ValidaNomeExiste(ValidaNomeNull(Console.ReadLine()));
            
            Console.Clear();
            Console.WriteLine("Informe a senha: ");
            var senhaDoUsuario = ValidaNomeNull(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Informe novamente a senha: ");
            var senhaDoUsuario2 = ValidaNomeNull(Console.ReadLine());
   
            if (senhaDoUsuario == senhaDoUsuario2)
            {
                usuariosController.CadastrarUser(new Usuario()
                {
                    Login = nomeDoUsuario,
                    Senha = senhaDoUsuario
                });
                Console.WriteLine("Usuario cadastrado com sucesso");
            }
            else
                Console.WriteLine("As senhas não conferem, usuario não cadastrado");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo para cadastrar um livro no sistema
        /// </summary>
        private static void CadastrarLivro()
        {
            Console.Clear();
            Console.WriteLine("Cadastrar livro dentro do sistema: ");
            Console.WriteLine("Informe o Nome do livro: ");
            var nomeDoLivro = ValidaNomeNull(Console.ReadLine());
            livrosController.CadastrarLivro(new Livro()
            {
                Nome = nomeDoLivro
            });
            Console.WriteLine("Livro cadastrado com sucesso");
            Console.ReadKey();
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

            Usuario user = new Usuario();

            user.Login = loginUser;
            user.Senha = senhaUser;

            return usuariosController.LoginSistema(user); 
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

        /// <summary>
        /// valida entradas de string para que não seja nulo
        /// </summary>
        /// <param name="notNull">recebe o valor da string</param>
        /// <returns>retorna o valor da string caso n seja nulo</returns>
        private static string ValidaNomeNull(string notNull)
        {
            while (notNull == "" )
            {
                Console.WriteLine("O valor inserido não pode ser nulo! Digite novamente: ");
                notNull = Console.ReadLine();
            }
            return notNull;
        }

        /// <summary>
        /// verifica se o login do usuario já existe no sistema
        /// </summary>
        /// <param name="nomeUser"></param>
        /// <returns>retorna o nome do usuario</returns>
        private static string ValidaNomeExiste(string nomeUser)
        {
            while (usuariosController.ValidaNomeExiste(nomeUser))
            {
                Console.Clear();
                Console.WriteLine("Usuario já existe no sistema");
                Console.WriteLine("Digite outro usuario para login: ");
                nomeUser = ValidaNomeNull(Console.ReadLine());
            }
            return nomeUser;
        }

        private static void RemoverUsuario()
        {
            Console.WriteLine("Remover um usuario pelo ID no sistema");
            MostrarUsuarios();
            Console.WriteLine("Informe o ID do usuario que deseja remover: ");
            var idUsuario = int.Parse(ValidaNomeNull(Console.ReadLine()));

            usuariosController.RemoverUsuarioPorId(idUsuario);
            Console.WriteLine("Usuario removido com sucesso");
            Console.ReadKey(true);
            
        }
    }
}

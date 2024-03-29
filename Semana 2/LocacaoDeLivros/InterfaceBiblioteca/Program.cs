﻿using System;
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
            // MostraTelaInicial();

            MostraMenuSistema();
        }

        //private static void MostraTelaInicial()
        //{
        //    Console.Clear();
        //    Console.WriteLine("-----SISTEMA DE LOCAÇÂO DE LIVROS-----");
        //    while (!RealizaLoginSistema())
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Login ou senha incorretos");
        //    }
        //}

        /// <summary>
        /// Mostra todos os usuarios cadastrados
        /// </summary>
        //private static void MostrarUsuarios()
        //{
        //    var modelUser = "ID:{0,-3} || Login:{1,-8} || Ativo:{2,-5}";
        //    usuariosController.RetornaListaDeUsuarios().ToList<Usuario>().ForEach(i => Console.WriteLine(string.Format(modelUser,i.Id,i.Login,i.Ativo)));
        //    Console.ReadKey(true);
        //}


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
                //   Console.WriteLine("1 - Listar Usuarios");
                Console.WriteLine("1 - Listar Livro");
                Console.WriteLine("2 - Cadastrar Livro");
                // Console.WriteLine("4 - Cadastrar Usuario");
                Console.WriteLine("3 - Atualizar Livro");
                // Console.WriteLine("5 - Remover Usuario");
                Console.WriteLine("4 - Remover Livro");
                // Console.WriteLine("9 - Fazer LogOff");
                Console.WriteLine("0 - Sair ");
                validado = ValidaMenu();


                switch (validado)
                {
                    //case 1:
                    //    //listar usuarios
                    //    MostrarUsuarios();
                    //    break;

                    case 1:
                        //mostrar livro
                        MostrarLivros();
                        Console.ReadKey(true);
                        break;

                    case 2:
                        //cadastrar livros
                        CadastrarLivro();
                        break;

                    case 3:
                        //cadastrar livros
                        AtualizarLivro();
                        break;


                    //case 4:
                    //    //cadastrar livros
                    //    CadastrarUser();
                    //    break;

                    // case 5:
                    //     //remover usuario
                    //     RemoverUsuario();
                    //     break; 

                    case 4:
                        //remover livro
                        RemoverLivro();
                        break;


                    //case 9:
                    //   Console.Clear();
                    //   while (!RealizaLoginSistema())
                    //   {
                    //       Console.Clear();
                    //       Console.WriteLine("Login ou senha incorretos");
                    //   }
                    //   break;

                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Metodo para cadastrar um livro no sistema
        /// </summary>
        // private static void CadastrarUser()
        // {
        //     Console.Clear();
        //     Console.WriteLine("Cadastrar usuario dentro do sistema: ");
        //     Console.WriteLine("Informe o login: ");
        //
        //     var nomeDoUsuario = ValidaNomeUsuarioExiste(ValidaNomeNull(Console.ReadLine()));
        //     
        //     Console.Clear();
        //     Console.WriteLine("Informe a senha: ");
        //     var senhaDoUsuario = ValidaNomeNull(Console.ReadLine());
        //     Console.Clear();
        //     Console.WriteLine("Informe novamente a senha: ");
        //     var senhaDoUsuario2 = ValidaNomeNull(Console.ReadLine());
        //
        //     if (senhaDoUsuario == senhaDoUsuario2)
        //     {
        //         usuariosController.CadastrarUser(new Usuario()
        //         {
        //             Login = nomeDoUsuario,
        //             Senha = senhaDoUsuario
        //         });
        //         Console.WriteLine("Usuario cadastrado com sucesso");
        //     }
        //     else
        //         Console.WriteLine("As senhas não conferem, usuario não cadastrado");
        //     Console.ReadKey();
        // }

        /// <summary>
        /// mostra os livros cadastrados
        /// </summary>
        private static void MostrarLivros()
        {
            var modelLivro = "ID:{0,-3} || Nome:{1,-30}";
            livrosController.RetornaListaDeLivros().ToList<Livro>().ForEach(i => Console.WriteLine(string.Format(modelLivro, i.Id, i.Nome)));
        }

        /// <summary>
        /// Metodo para cadastrar um livro no sistema
        /// </summary>
        private static void CadastrarLivro()
        {
            Console.Clear();
            Console.WriteLine("Cadastrar livro dentro do sistema: ");
            Console.WriteLine("Informe o Nome do livro: ");
            var nomeDoLivro = ValidaNomeLivroExiste(Console.ReadLine());
            var resultado = livrosController.CadastrarLivro(new Livro() { Nome = nomeDoLivro });
            if (resultado)
                Console.WriteLine("Livro cadastrado com sucesso");
            else
                Console.WriteLine("Erro ao cadastrar livro");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
            Console.ReadKey(true);
            Console.Clear();
        }


        private static void AtualizarLivro()
        {
            Console.WriteLine("-- Atualizar Livro --");
            MostrarLivros();
            Console.WriteLine("Digite o ID do livro que Deseja Alterar!!");
            var id = int.Parse(Console.ReadLine());
            if (id == 123321)
            {
                Console.WriteLine("-----------------------MODO ADMIN-------------------------");
                Console.WriteLine("   Insira o ID do livro que voce deseja alterar o estado  ");
                Console.WriteLine("-----------------------MODO ADMIN-------------------------");
                var modelLivro = "ID:{0,-3} || Nome:{1,-30}";
                livrosController.RetornaListaAdmin().ToList<Livro>().ForEach(i => Console.WriteLine(string.Format(modelLivro, i.Id, i.Nome)));
                var idAdmin = int.Parse(Console.ReadLine());
                var livroAdmin = livrosController.RetornaListaAdmin().FirstOrDefault(x => x.Id == idAdmin);
               
                livroAdmin.Ativo = true;
                Console.WriteLine("Alterando para ativo = true este livro");
                
                var resultadoAdmin = livrosController.AtualizarLivro(livroAdmin);

                if (resultadoAdmin)
                    Console.WriteLine("Livro Atualizado com Sucesso!!!");
                else
                    Console.WriteLine("Erro ao Atualizar livro, confira os dados inseridos");

                Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
                Console.ReadKey(true);
                Console.Clear();
                return;
            }
            var livro = livrosController.RetornaListaDeLivros().FirstOrDefault(x => x.Id == id);

            

            if (livro == null)
            {
                Console.WriteLine("ID do livro não existe");
                Console.ReadKey(true);
                return;
            }
            Console.WriteLine("Digite o Nome do Livro");
            var livroUser = Console.ReadLine();
            
            livro.Nome = ValidaNomeLivroExiste(livroUser);

            var resultado = livrosController.AtualizarLivro(livro);

            if (resultado)
                Console.WriteLine("Livro Atualizado com Sucesso!!!");
            else
                Console.WriteLine("Erro ao Atualizar livro, confira os dados inseridos");

            Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
            Console.ReadKey(true);
            Console.Clear();
        }


        /// <summary>
        /// metodo para remover livro do sistema
        /// </summary>
        private static void RemoverLivro()
        {
            Console.WriteLine("---Remover um livro pelo ID no sistema--");
            MostrarLivros();
            Console.WriteLine("Informe o ID do livro que deseja remover: ");
            var idLivro = int.Parse(Console.ReadLine());

            if (livrosController.RemoverLivro(idLivro))
                Console.WriteLine("Livro removido com sucesso!!!");
            else
                Console.WriteLine("ID do livro não existe ou já foi removido");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
            Console.ReadKey(true);
            Console.Clear();
        }

        /// <summary>
        /// verifica se o nome do livro ja existe no sistema
        /// </summary>
        /// <param name="nomeLivro">nome do livro a ser procurado</param>
        /// <returns>o nome do sistema que não existe no sistema</returns>
        private static string ValidaNomeLivroExiste(string nomeLivro)
        {
            while (livrosController.ValidaNomeLivroExiste(nomeLivro))
            {
                Console.Clear();
                Console.WriteLine("Livro já existe no sistema");
                Console.WriteLine("Digite outro livro para cadastrar: ");
                nomeLivro = Console.ReadLine();
            }
            return nomeLivro;
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
        /// Confere se o login e senha informado estão no sistema
        /// </summary>
        /// <returns>retorna 'true' caso esteja ou 'false' caso não esteja</returns>
        //private static bool RealizaLoginSistema()
        //{
        //    Console.WriteLine("Informe seu login e senha para acessar o sistema");
        //    Console.WriteLine("Login: ");
        //    var loginUser = Console.ReadLine();
        //    Console.WriteLine("Senha: ");
        //    var senhaUser = Console.ReadLine();
        //
        //    Usuario user = new Usuario();
        //
        //    user.Login = loginUser;
        //    user.Senha = senhaUser;
        //
        //    return usuariosController.LoginSistema(user); 
        //}


        /// <summary>
        /// valida entradas de string para que não seja nulo
        /// </summary>
        /// <param name="notNull">recebe o valor da string</param>
        /// <returns>retorna o valor da string caso n seja nulo</returns>
        // private static string ValidaNomeNull(string notNull)
        // {
        //     while (notNull == "" )
        //     {
        //         Console.WriteLine("O valor inserido não pode ser nulo! Digite novamente: ");
        //         notNull = Console.ReadLine();
        //     }
        //     return notNull;
        // }

        /// <summary>
        /// verifica se o login do usuario já existe no sistema
        /// </summary>
        /// <param name="loginUser"></param>
        /// <returns>retorna o nome do usuario</returns>
        //private static string ValidaNomeUsuarioExiste(string loginUser)
        //{
        //    while (usuariosController.ValidaNomeExiste(loginUser))
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Usuario já existe no sistema");
        //        Console.WriteLine("Digite outro usuario para login: ");
        //        loginUser = ValidaNomeNull(Console.ReadLine());
        //    }
        //    return loginUser;
        //}


        /// <summary>
        /// Metodo para remover usuario do sistema
        /// </summary>
        //private static void RemoverUsuario()
        //{
        //    Console.WriteLine("Remover um usuario pelo ID no sistema");
        //    MostrarUsuarios();
        //    Console.WriteLine("Informe o ID do usuario que deseja remover: ");
        //    var idUsuario = int.Parse(ValidaNomeNull(Console.ReadLine()));
        //
        //    if (usuariosController.RemoverUsuarioPorId(idUsuario))
        //        Console.WriteLine("Usuario removido com sucesso");
        //    else
        //        Console.WriteLine("ID usuario não existe ou já foi removido");
        //    Console.ReadKey(true);
        //    
        //}
    }
}

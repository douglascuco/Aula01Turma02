using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaListagem.Model;
using BibliotecaListagem.Controller;

namespace ViewListandoNomes
{
    class Program
    {
        static ControllerPessoas controller = new ControllerPessoas();

        static void Main(string[] args)
        {
            var resultado = int.MinValue;

            while(resultado != 0)
            {
                Console.Clear();
                Console.WriteLine("-----MENU SISTEMA------");
                Console.WriteLine("Selecione um item do menu: ");
                Console.WriteLine("1 - Adicionar Nome");
                Console.WriteLine("2 - Listar Nomes");
                Console.WriteLine("0 - Sair");
                resultado = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch(resultado)
                {
                    case 1:
                        AdicionarNome();
                        break;
                    case 2:
                        ListarNomes();
                        break;

                    default:
                        break;
                    case 0:
                        break;
                }
            }
        }


        public static void ListarNomes()
        {
            Console.WriteLine("-----Listagem de Nomes-----");
            controller.GetPessoas().ForEach(x => Console.WriteLine($"Id: {x.Id} || Nome: {x.Nome}"));
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey(true);
            Console.Clear();
        }


        public static void AdicionarNome()
        {
            Console.WriteLine("-----Adicionar Nome------");
            Console.WriteLine("Digite o nome para ser adicionado: ");
            var nome = Console.ReadLine();
            var resultado = controller.AddPessoa(new Pessoa() { Nome = nome });
            if (resultado)
                Console.WriteLine("Nome Adicionado com Sucesso!!!");
            else
                Console.WriteLine("Erro ao adicionar nome ):");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}

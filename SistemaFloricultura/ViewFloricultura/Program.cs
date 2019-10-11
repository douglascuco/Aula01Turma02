using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaFloricultura.Controller;
using BibliotecaFloricultura.Model;

namespace ViewFloricultura
{
    public class Program
    {
        static ControllerFlores controller = new ControllerFlores();
        static void Main(string[] args)
        {
            var resultado = int.MinValue;

            while (resultado != 0)
            {
                Console.Clear();
                Console.WriteLine("-----MENU SISTEMA------");
                Console.WriteLine("Selecione um item do menu: ");
                Console.WriteLine("1 - Adicionar Flor");
                Console.WriteLine("2 - Listar Flores");
                Console.WriteLine("3 - Relatorio Flores");
                Console.WriteLine("0 - Sair");
                resultado = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch (resultado)
                {
                    case 1:
                        AdicionarNome();
                        break;
                    case 2:
                        ListarNomes();
                        break;
                    case 3:
                        RelatorioFlores();
                        break;

                    default:
                        break;
                    case 0:
                        break;
                }
            }
        }


        private static void ListarNomes()
        {
            Console.WriteLine("-----Listagem de Flores-----");
            controller.GetFlores().ToList<Flor>().ForEach(x => Console.WriteLine($"Id: {x.Id} || Nome: {x.Nome} || Quantidade: {x.Quantidade}"));
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey(true);
            Console.Clear();
        }


        private static void AdicionarNome()
        {
            Console.WriteLine("-----Adicionar Flor------");
            Console.WriteLine("Digite o nome da flor: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de flores: ");
            var quant = int.Parse(Console.ReadLine());
            var resultado = controller.AddFlor(new Flor() { Nome = nome, Quantidade = quant});
            if (resultado)
                Console.WriteLine("Flor Adicionado com Sucesso!!!");
            else
                Console.WriteLine("Erro ao adicionar flor ):");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey(true);
            Console.Clear();
        }

        private static void RelatorioFlores()
        {
            Console.WriteLine("-----Relatorio Flores------");
            Console.WriteLine("-----Ordenando por maior quantidade------");

            var resultado = controller.GetFlores().OrderByDescending(x => x.Quantidade);
            //resultado.ToList<string>().ForEach(x => Console.WriteLine($"Nome: {x.Key["Nome"]} || Quantidade: {x.Key["Quantidade"]}"));
            resultado.ToList<Flor>().ForEach(x => Console.WriteLine($"Nome: {x.Nome} || Quantidade: {x.Quantidade}"));

            var somaTotal = controller.GetFlores().Sum(x => x.Quantidade);
            Console.WriteLine($"Quantidade Total : {somaTotal}");

            Console.ReadKey(true);
            Console.Clear();
        }

    }
    
}

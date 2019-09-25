using ExercícioLinq.BD;
using ExercícioLinq.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioLinq
{
    class Program
    {
        static CarroController carroController = new CarroController();
        static void Main(string[] args)
        {
            MenuVendas();
        }

        private static void MenuVendas()
        {
            Console.WriteLine("---------------BEM VINDO--------------");
            Console.WriteLine("Mostrando tabela das vendas:");
            MostrarTabela();

            Console.WriteLine("Informe o numero do mês que deseja saber sobre a venda");
            var mesVenda = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"Listando Informações das vendas do mes {mesVenda}");
            MostrarSomaTotalMes(mesVenda);
            MostrarMediaVendasMes(mesVenda);
            Console.ReadKey();
        }

        private static void MostrarTabela()
        {
            var modeloTabela = "ID: {0,-5} Nome Carro: {1,-35} Valor: {2,-10} Quantidade: {3,-5} Data Venda: {4,-10}";
            carroController.MostraVendas().ForEach(x => Console.WriteLine(string.Format(modeloTabela, x.Id, x.Nome, x.Valor.ToString("C"), x.Quantidade, x.DataVenda.ToShortDateString())));

        }

        private static void MostrarSomaTotalMes(int mesVenda)
        {
            Console.WriteLine("Soma total das vendas do mes: " + carroController.MostraVendasUsuario(mesVenda).Sum(x => x.Valor * x.Quantidade).ToString("C"));
        }
        private static void MostrarMediaVendasMes(int mesVenda)
        {
            Console.WriteLine("Media das vendas do mes: " + carroController.MostraVendasUsuario(mesVenda).Average(x => x.Valor * x.Quantidade).ToString("C"));
        }
    }
}

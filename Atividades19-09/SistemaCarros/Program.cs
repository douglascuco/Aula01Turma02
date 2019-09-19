using SistemaCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarListaCarros(CadastrarCarros());
        }

        private static List<Carro> CadastrarCarros()
        {
            var listaCarros = new List<Carro>();
            var resposta = "1";
            while (resposta == "1")
            {
                var modeloCarro = new Carro();
                Console.WriteLine("Digite a marca: ");
                modeloCarro.Marca = Console.ReadLine();
                Console.WriteLine("Digite o modelo: ");
                modeloCarro.Modelo = (Console.ReadLine());
                Console.WriteLine("Digite o ano: ");
                modeloCarro.Ano = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor: ");
                modeloCarro.Valor = double.Parse(Console.ReadLine());


                listaCarros.Add(modeloCarro);
                Console.WriteLine("Olá, deseja cadastrar mais uma pessoa? Tecle 1 para sim ou outra tecla para sair");
                resposta = Console.ReadLine();
            }
            return listaCarros;
        }

        private static void MostrarListaCarros(List<Carro> listaCarros)
        {
            listaCarros.ForEach(i => Console.WriteLine($"Marca: {i.Marca} Modelo: {i.Modelo} Ano: {i.Ano} Valor: {i.Valor.ToString("C")}"));
            Console.ReadKey();
        }
    }
}

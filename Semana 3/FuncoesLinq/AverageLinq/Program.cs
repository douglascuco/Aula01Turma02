using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Venda> listaVendas = new List<Venda>()
            {
                new Venda()
                {
                    Produto = "XIAOMI Lite 6 quad core 128gb 32px frontal",
                    Quantidade = 8,
                    Valor = 1250.50
                },

                new Venda()
                {
                    Produto = "ASUS zenPhone 4 quad core 32gb",
                    Quantidade = 5,
                    Valor = 898.99
                }
            };

            Console.WriteLine("Media de produtos vendidos neste mes");
            Console.WriteLine(listaVendas.Average(x => x.Quantidade));
            Console.WriteLine("Media total de ven das neste mes");
            Console.WriteLine(listaVendas.Average(x => (x.Valor * x.Quantidade)).ToString("C"));

            Console.ReadKey();
        }
    }
}

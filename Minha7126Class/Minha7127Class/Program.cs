using Minha7127Class.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minha7127Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeFrutas = new List<CestaDeFrutas>()
            {
                new CestaDeFrutas()
                {
                    Fruta = "Tomate",
                    Quantidade  = 4
                },
                
                new CestaDeFrutas()
                {
                    Fruta = "Abacate",
                    Quantidade  = 2
                },

                new CestaDeFrutas()
                {
                    Fruta = "Maçã",
                    Quantidade  = 6
                },

                new CestaDeFrutas()
                {
                    Fruta = "Banana",
                    Quantidade  = 1
                }
            };

            listaDeFrutas.ForEach(i => Console.WriteLine($"Na sua Cesta tem {i.Quantidade} {i.Fruta}(s)."));
            Console.ReadKey();
        }
    }
}

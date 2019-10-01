using Minha7126Class.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minha7126Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaBicicleta = new List<Bicicleta>
            {
                new Bicicleta()
                {
                    Marca = "Caloi"
                },


                new Bicicleta()
                {
                    Marca = "Monark"
                }
            };

            listaBicicleta.ForEach(i =>
            Console.WriteLine($"BikeOn > Marca:{i.Marca} Pneus:{i.Pneu}"));
            Console.ReadKey();
        }
    }
}

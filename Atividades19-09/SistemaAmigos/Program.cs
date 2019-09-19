using SistemaAmigos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAmigos
{
    class Program
    {
        static void Main(string[] args)
        {
            var amigos = new List<Amigos>()
            {
                new Amigos
                {
                    Nome = "Florentina",
                    TempoAmizade = 25
                },

                new Amigos
                {
                    Nome = "Thiago",
                    TempoAmizade = 12
                },

                new Amigos
                {
                    Nome = "Felipe",
                    TempoAmizade = 5
                }
            };

            amigos.ForEach(i => Console.WriteLine($"Amigo: {i.Nome} Tempo de amizade: {i.TempoAmizade} meses."));
            Console.ReadKey();
            
        }
    }
}

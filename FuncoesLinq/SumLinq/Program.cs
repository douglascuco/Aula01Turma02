using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            // SomarInteiroPrimitivo();
            // SomaInteirosLista();
            SomaBalasListaDeCriancas();
            Console.ReadKey();

        }

        private static void SomarInteiroPrimitivo()
        {

            int[] collecaoInteiros = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(collecaoInteiros.Sum());
        }

        private static void SomaInteirosLista()
        {
            List<int> listaInteiros = new List<int>()
            {
                1,2,3,4,5,63
            };

            Console.WriteLine(listaInteiros.Sum());
        }

        private static void SomaBalasListaDeCriancas()
        {
            List<Crianca> criancas = new List<Crianca>()
            {
                new Crianca()
                {
                    Nome = "Joaozinho",
                    Balas = 9
                },

                new Crianca()
                {
                    Nome = "Maria",
                    Balas = 14
                },

                new Crianca()
                {
                    Nome = "Fulaninho",
                    Balas = 4
                }
            };

            Console.WriteLine(criancas.Sum(x => x.Balas));

        }

    }
}

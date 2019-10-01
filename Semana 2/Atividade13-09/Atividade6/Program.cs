using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    class Program
    {
        static void Main(string[] args)
        {
            //  6 - Criar um console app que quando informado o texto contendo banana ele troque esta informação por laranja
            TrocaLaranjaText(UserText());
            Console.ReadKey();
        }

        private static string UserText()
        {
            Console.WriteLine("Informe o texto: ");
            return Console.ReadLine();
        }
        private static void TrocaLaranjaText(string texto)
        {
             Console.WriteLine(texto.Replace("banana","laranja"));
        }
    }
}

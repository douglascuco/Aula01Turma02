using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 - Criar um console app que apresente o primeiro e o ultimo caractere de uma palavra informada.
            Console.WriteLine($"A primeira letra é '{UserText()[0]}' e a ultima letra é '{UserText()[UserText().Length - 1]}'");
            Console.ReadKey();
        }

        private static string UserText()
        {
            Console.WriteLine("Informe a palavra: ");
            return Console.ReadLine();
        }
    }
}

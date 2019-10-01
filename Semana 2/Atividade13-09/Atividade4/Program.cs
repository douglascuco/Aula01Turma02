using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            //  4 - Criar um console app que apresente a quantidade total de caracteres que contém em um texto informado
            //  pelo usuário.

            Console.WriteLine($"O tamanho do texto é de {UserText().Length} caracteres");
            Console.ReadKey();
        }
        /// <summary>
        /// Pega o texto do usuario
        /// </summary>
        /// <returns>retorna o texto do usuario em string</returns>
        private static string UserText()
        {
            Console.WriteLine("Informe o texto que você deseja saber o tamanho: ");
            return Console.ReadLine();
        }
    }
}

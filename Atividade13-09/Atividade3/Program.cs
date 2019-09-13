using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 - Criar um console app que solicite o nome e a idade, e após informar nome e idade o mesmo
            //     deverá apresentar quando maior ou igual a 18 anos a seguinte informação:
            //     "Parabéns {nome} você já esta na fase adulta."
            //     caso menor de 18 anos o mesmo deverá apresentar a seguinte informação:
            //     "Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade."
            var nome = PergNome();
            var idade = PergIdade();
            if (idade < 18)
                Console.WriteLine($"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade.");
            else
                Console.WriteLine($"Parabéns {nome} você já esta na fase adulta.");
            Console.ReadKey();



        }
        /// <summary>
        /// pergunta o nome 
        /// </summary>
        /// <returns>retorna o nome em string</returns>
        private static string PergNome()
        {
            Console.WriteLine("Informe seu nome completo: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// pergunta a idade
        /// </summary>
        /// <returns>retorna a idade em int</returns>
        private static int PergIdade()
        {
            Console.WriteLine("Informe sua idade: ");
            return int.Parse(Console.ReadLine());
        }




    }
}

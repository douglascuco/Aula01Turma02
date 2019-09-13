using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();

            while (PerguntaConversa() == 1)
            {
                PerguntaBeber(PerguntaNome());
            }
        }
        /// <summary>
        /// Mostra o Cabeçalho no console
        /// </summary>
        private static void ShowInitAppText()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("--Seja bem vindo--");
            Console.WriteLine("------------------");
        }

        /// <summary>
        /// Faz a pergunta se o usuario quer conversar
        /// </summary>
        /// <returns>Numero inteiro em relação a pergunta</returns>
        private static int PerguntaConversa()
        {
            Console.WriteLine("\r\nVamos Conversar? sim(1) nao(2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }
        /// <summary>
        /// Pergunta ao usuario se ele quer sair para beber algo
        /// </summary>
        private static void PerguntaBeber(string nome)
        {
            Console.WriteLine($"\r\n Você quer sair pra beber algo {nome}? sim(1) nao(2)");
            var a = int.Parse(Console.ReadKey().KeyChar.ToString());
            if (a == 1)
            {
                Console.WriteLine($"\r\n Qual sua idade {nome}?");
                var idade = Console.ReadLine();
                if (int.Parse(idade) > 17)
                    Console.WriteLine($"\r\nBora beber uma cerva então {nome}!");
                else
                    Console.WriteLine($"\r\nTenho suco de laranja para você então {nome}!");
            }
            else
                Console.WriteLine($"\r\nDeixamos pra próxima então {nome}... ):");
        }

        /// <summary>
        /// Pergunta o nome
        /// </summary>
        /// <returns>o valor string do nome</returns>
        private static string PerguntaNome()
        {
            Console.WriteLine("\r\nQual seu nome?");
            return Console.ReadLine();
        }

    }
}

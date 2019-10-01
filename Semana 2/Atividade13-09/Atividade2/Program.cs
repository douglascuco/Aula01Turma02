using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome(RespNome());            
        }
        /// <summary>
        /// Pergunta o nome do usuario
        /// </summary>
        /// <returns>Retorna o nome do usuario em string</returns>
        private static string RespNome()
        {
            Console.WriteLine("Infome seu nome completo: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Boas vindas no console
        /// </summary>
        /// <param name="nome">String do nome da pessoa</param>
        private static void Welcome(string nome)
        {
            Console.WriteLine($"Bem vindo {nome}! Para encerrar a aplicação aperte qualquer tecla!");
            Console.ReadKey();
        }
    }
}

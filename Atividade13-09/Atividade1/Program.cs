using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
        }
        /// <summary>
        /// Boas vindas
        /// </summary>
        private static void Welcome()
        {
            Console.WriteLine("Bem vindo! Para encerrar a aplicação aperte qualquer tecla!");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Texto informativo para consultar o livro
            //pelo numero de registro do sistema
            Console.Write("Informe o livro a ser consultado: ");
            var numeroDoLivro = Console.ReadLine();
            while (numeroDoLivro != "sair")
            {
                if (numeroDoLivro == "123456" )
                {
                    Console.WriteLine("Livro  Indisponivel");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Deseja alocar o livro? sim(1) não(2)");
                    var resposta = Console.ReadLine();
                    if(resposta == "1")
                    {
                        Console.WriteLine("Livro alocado!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Livro não alocado!");
                        Console.ReadKey();
                    }
                    Console.WriteLine("Deseja alocar outro livro? sim(1) não(2)");
                    var resposta2 = Console.ReadLine();
                    if (resposta2 == "2")
                    {
                        return;
                    }
                }
                Console.Write("Informe o livro a ser consultado: ");
                numeroDoLivro = Console.ReadLine();
            }
        }
    }
}

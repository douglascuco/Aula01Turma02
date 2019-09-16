using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeInfo
{
    class Program
    {
        static List<string> minhaLista = new List<string>
            {
                "Felipe",
                "Irineu",
                "Hernandes"
            };
        static void Main(string[] args)
        {
            adicionarLista();
            Console.Clear();
            ListaInfo();
            Console.ReadKey();
        }

        private static void adicionarLista()
        {
            Console.Clear();
            Console.WriteLine("\r\nInforme um nome");
            minhaLista.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("\r\nDeseja Informar mais valores? sim(S) não(N) ");

            if (Console.ReadLine().ToLower() == "s")
                adicionarLista();

        }

        private static void ListaInfo()
        {
            Console.WriteLine("Nomes adicionados a lista: ");

            foreach (var item in minhaLista)
                Console.WriteLine($"Nome: {item} foi adicionado a lista");
        }
    }
}

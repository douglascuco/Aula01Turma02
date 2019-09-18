using MinhaBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessarInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();
        }

        private static void MenuSistema()    
        {
            Console.WriteLine("Escolha uma das opções do menu:");
            Console.WriteLine("1 - Calculo de area");
            Console.WriteLine("2 - Mostrar árvore");
            Console.WriteLine("3 - Mostrar carros");
            Console.WriteLine("4 - Mostrar cervejas");
            Console.WriteLine("0 - Sair do sistema");

            var menuEscolhido = Console.ReadLine();

            switch (menuEscolhido)
            { 
                case "1":
                    CalculaArea();
                    Console.ReadKey();
                    MenuSistema();
                    break;

                case "2":
                    var arvore = new MostraArvore();
                    arvore.CriarArv();
                    Console.ReadKey();
                    MenuSistema();
                    break;

                case "3":
                    var carro = new MostrarCarros();
                    carro.MostrarMarcas();
                    Console.ReadKey();
                    MenuSistema();
                    break;

                case "4":
                    var cerveja = new MostrarCerveja();
                    cerveja.MostrarCervejas();
                    Console.ReadKey();
                    MenuSistema();
                    break;

                case "0":
                    break;

                default:
                    Console.WriteLine("Numero invalido digite outro numero");
                    Console.ReadKey();
                    MenuSistema();
                    break;
            }
        }

        public static void CalculaArea()
        {
            Console.WriteLine("Informa o lado do quadrado: ");
            var lado = (double.Parse(Console.ReadLine()));
            var BibliotecaDeCalculos = new CalculosDeArea();
            Console.WriteLine($"Sua Area é de {BibliotecaDeCalculos.CalculaAreaQuadrado(lado)}");
        }
    }
}

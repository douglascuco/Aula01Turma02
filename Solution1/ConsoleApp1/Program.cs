using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeArea
{
    class Program
    {
        const double pi = 3.1415;
       
        static void Main(string[] args)
        {
            var area = 0.0;
            Console.WriteLine("Qual o tipo do elemento que você quer descobrir a área? Circulo(1) Triangulo(2) Quadrado(3) Retângulo(4) SAIR(0)");
            var resposta = Console.ReadKey().KeyChar.ToString() ;
            
            while (resposta != "0")
            {
                switch (resposta)
                {
                    case "1":
                        Console.WriteLine("\r\nInsira o valor do raio do círculo em metros");
                        double raio = double.Parse(Console.ReadLine());
                        area = pi * (raio * raio);
                        Console.WriteLine($"Sua área é: {area} metros");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("\r\nInsira o valor da altura do Triangulo em metros: ");
                        var altura = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o valor da base do Triangulo em metros: ");
                        var baseTri = double.Parse(Console.ReadLine());
                        area = (altura * baseTri) / 2;
                        Console.WriteLine($"A área do triangulo é de: {area} metros");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("\r\nInsira o valor do lado do quadrado em metros: ");
                        var lado = double.Parse(Console.ReadLine());
                        area = lado * lado;
                        Console.WriteLine($"O valor da area do quadrado é de: {area} metros");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("\r\nInsira o valor de um lado do retângulo em metros: ");
                        var lado1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o valor do outro lado do retângulo em metros: ");
                        var lado2 = double.Parse(Console.ReadLine());
                        area = lado1 * lado2;
                        Console.WriteLine($"O valor da area do retângulo é de: {area} metros");
                        Console.ReadKey();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine(" \r\n NUMERO INVALIDO, utilize numeros de 1 a 4");

                        break;
                }
                Console.WriteLine("Qual o tipo do elemento que você quer descobrir a área? Circulo(1) Triangulo(2) Quadrado(3) Retângulo(4) SAIR(0)");
                resposta = Console.ReadKey().KeyChar.ToString();
            }

        }
            
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public class Program
    {
         static void Main(string[] args)
         {
           
         }

        public static void ConversorDeMoeda()
        {
            Console.WriteLine("-----Sistema conversor de moedas cabuloso-----");
            Console.WriteLine("---Informe um valor em REAL a ser convertido---");
            var valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Para qual moeda vc deseja converter? ");
            Console.WriteLine("DOLAR, EURO, YEN, BTC");
            var tipoMoeda = Console.ReadLine();
            ConvertMoeda(valor1, tipoMoeda.ToUpper());
            Console.ReadKey();

        }

        /// <summary>
        /// Converte reais em o tipo de moeda que foi dado
        /// </summary>
        /// <param name="minhaMoeda">Valor em real</param>
        /// <param name="moedaAlvo">Tipo da moeda a ser convertida</param>
        public static void ConvertMoeda(double minhaMoeda, string moedaAlvo)
        {
            switch (moedaAlvo)
            {
                case "DOLAR":
                    Console.WriteLine(FormataNumeroDecimalEmDolar(minhaMoeda));
                    break;

                case "EURO":
                    Console.WriteLine(FormataNumeroDecimalEmEuro(minhaMoeda));
                    break;

                case "YEN":
                    Console.WriteLine(FormataNumeroDecimalEmYen(minhaMoeda));
                    break;

                case "BTC":
                    Console.WriteLine(FormataNumeroDecimalEmBit(minhaMoeda));
                    break;

                default:
                    Console.WriteLine("MOEDA INVALIDA, UTILIZE UMA DAS MOEDAS ABAIXO");
                    Console.WriteLine("DOLAR, EURO, YEN, BTC");
                    ConvertMoeda(minhaMoeda, Console.ReadLine().ToUpper());
                    break;
            }
                
        }

        /// <summary>
        /// Metodo para conversão de reais para dolar
        /// </summary>
        /// <param name="dec">Numero em real</param>
        /// <returns>Retorna valor formatado em dolar</returns>
        private static string FormataNumeroDecimalEmDolar(double dec)
        {
            return (dec / 4.5008).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
        }

        /// <summary>
        /// Metodo para conversão de reais para Euro
        /// </summary>
        /// <param name="dec">Numero em real</param>
        /// <returns>retorna o valor formatado em euro</returns>
        private static string FormataNumeroDecimalEmEuro(double dec)
        {
            return (dec / 4.53).ToString("C2", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "Euro ");
        }

        /// <summary>
        /// Metodo para conversão de Real para Yen
        /// </summary>
        /// <param name="dec">Numero em real</param>
        /// <returns>Valor formatado em Yen</returns>
        private static string FormataNumeroDecimalEmYen(double dec)
        {
            return (dec / 0.038).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));
        }

        /// <summary>
        /// metodo para conversao de real para bitcoin
        /// </summary>
        /// <param name="dec">Numero em real</param>
        /// <returns>Valor formatado para bitcoin</returns>
        private static string FormataNumeroDecimalEmBit(double dec)
        {
            return "BTC " + (dec / 41767.07).ToString("N6");
        }

    }
}

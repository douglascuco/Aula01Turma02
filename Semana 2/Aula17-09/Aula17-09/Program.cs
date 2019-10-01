using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17_09
{
    class Program
    {
        static void Main(string[] args)
        {
           // ListaDateTime();
           // ListaInt();
            ListaDec();
           // ListaString();
            Console.ReadKey();
        }


        /// <summary>
        /// Mostra lista de datas e horas
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();

            DateTime data = DateTime.Now;

            minhaLista.Add(new DateTime(2019, 9, 17, 20, 30, 58));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));
            minhaLista.Add(data);

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToLongDateString()));
        }


        /// <summary>
        /// Mostra lista de strings
        /// </summary>
        private static void ListaString()
        {

            var minhaLista = new List<string>();
    
            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");
            minhaLista.Add("ASUS");

            minhaLista.ForEach(i => Console.WriteLine(i));
        }


        /// <summary>
        /// Lista de numeros inteiros
        /// </summary>
        private static void ListaInt()
        {
            var minhaLista = new List<int>();

            minhaLista.Add(17);
            minhaLista.Add(18);
            minhaLista.Add(19);
            minhaLista.Add(20);

            minhaLista.ForEach(i => Console.WriteLine(i));
        }


        /// <summary>
        /// mostra lista de numeros decimais
        /// </summary>
        private static void ListaDec()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.25);
            minhaLista.Add(5.46);
            minhaLista.Add(minhaLista[1] * 1000000);

            minhaLista.ForEach(i => Console.WriteLine(i.ToString("C") + "  ||  " + FormataNumeroDecimalEmDolar(i) 
                                                                      + "  ||  " + FormataNumeroDecimalEmEuro(i)   
                                                                      + "  ||  " + FormataNumeroDecimalEmYen(i) 
                                                                      + "  ||  " + FormataNumeroDecimalEmBit(i)));
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

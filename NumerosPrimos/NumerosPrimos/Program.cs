using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Insira até que numero inteiro vc deseja visualizar os numeros primos: ");
            int max = 50;//int.Parse(Console.ReadLine());
            bool ePrimo = true;
            List<int> numPrimo = new List<int>();
            for (int i = 3; i <= max; i++)
            {             
                if (i % 2 != 0) //tira os numeros pares
                {
                    ePrimo = true;
                    int impar = i;
                    for (int j = 2; j < impar; j++)
                    {                           
                        if (impar % j == 0)
                        {
                            int naoPrimo = impar;
                            ePrimo = false;
                        }                                                     
                    }
                    if(ePrimo == true)
                        //Console.WriteLine(impar);
                        numPrimo.Add(impar);
                }
            }
            //numPrimo.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}

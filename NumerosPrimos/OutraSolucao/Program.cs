using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutraSolucao
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            int b = 100000;//int.Parse(Console.ReadLine());
            while(i <= b)
            {
                int j = 2;
                while (j < i && i % j != 0)
                    j++;
                if (i == j)
                    Console.WriteLine(i.ToString());
                    i++;
                
            }
           // Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisandoEntity.Model;
using RevisandoEntity.Controller;

namespace AplicacaoVisual
{
    class Program
    {
        static CervejaController cerveja = new CervejaController();
        static void Main(string[] args)
        {
            cerveja.AddCerveja(new Cerveja() { Nome = "Cerveja Antartica" });

            cerveja.GetCervejas().ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome)) ;


            Console.ReadKey();
        }
    }
}

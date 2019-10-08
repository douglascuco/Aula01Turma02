using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Model;
using CodeFirstTeste.Controller;

namespace GambCodaFirst
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            cervejaController.AddCerveja(new Cerveja() { Nome = "Cerveja Skol" });
                
        }
    }
}

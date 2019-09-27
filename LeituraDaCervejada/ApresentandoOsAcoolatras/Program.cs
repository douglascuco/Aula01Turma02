using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;

namespace ApresentandoOsAcoolatras
{
    class Program
    {

        static CervejaController cervejaController = new CervejaController();

        static void Main(string[] args)
        {
            cervejaController.AdicionarCerveja(new Cerveja
            { Id = cervejaController.GetCervejas().Count, Nome = "Heineken", Valor = 3.99, Litros = 0.35, Alcool = 3.75 }); ;


            cervejaController.GetCervejas().ForEach(x => Console.WriteLine($"Id: {x.Id} Cerveja: {x.Nome} Valor: {x.Valor.ToString("C")} Alcool: {x.Alcool} Litros: {x.Litros}"));

            Console.WriteLine($"Total Litros: {cervejaController.ValorTotalEmLitros()}");
            Console.WriteLine($"Valor Total: {cervejaController.ValorTotalCervejas().ToString("C")}");
            cervejaController.TesteBafometro();



            Console.ReadKey();

        }
    }
}

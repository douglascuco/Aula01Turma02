using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace teste
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)

        {
            Console.WriteLine("Informe o nome da cerveja: ");
            var nomeCerveja = Console.ReadLine();
            var novaCerveja = new Cerveja { Nome = nomeCerveja, Litros = 0.35, Alcool = 3.7, Valor = 2.85 };
            cervejaController.AdicionaItensLista(novaCerveja);
            cervejaController.RetornaListaCervejas().ForEach(x => Console.WriteLine($"ID: {x.Id} Cerveja: {x.Nome} Valor: {x.Valor} Litros: {x.Litros}"));
            Console.WriteLine(cervejaController.ValorTotalCervejas().ToString("C"));
            Console.WriteLine(cervejaController.LitrosTotalCervejas());
            Console.WriteLine("Digite o seu peso");
            var pesoUser = double.Parse(Console.ReadLine());
         ///Console.WriteLine("Digite a cerveja que você bebeu");
         ///var bebidaUser = Console.ReadLine();
         ///Console.WriteLine("Digite a quantidade que você bebeu");
         ///var quantidadeUser = int.Parse(Console.ReadLine());
            var alcoolNoSangue = cervejaController.FoiPreso(pesoUser);
            if (alcoolNoSangue > 0.25)
                Console.WriteLine($"Você foi pego em flagrante com {alcoolNoSangue}gramas de alcool/litros de sangue!");
            else
                Console.WriteLine("Escapou dessa vez");
            Console.ReadKey();
        }
    }
}

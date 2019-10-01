using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachSplitCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachSplitList();
        }

        public static void ForeachSplitList()
        {
            var conteudo = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:201";
            var listaDeInformacoes = conteudo.Split(';');


            Console.WriteLine("Veículos Cadastrados: ");
            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }

            Console.WriteLine("Informe o nome do veiculo");
            var nomeBusca = Console.ReadLine();
            var achou = false;

            foreach (var item in listaDeInformacoes)
            {
                var infoSplit = item.Split(',');

                var nome = infoSplit[0].Split(':')[1];
                var marca = infoSplit[1].Split(':')[1];
                var ano = infoSplit[2].Split(':')[1];

                if (nome == nomeBusca)
                {
                    Console.WriteLine($"O Veículo '{nome}' da marca '{marca}' é do ano '{ano}'");
                    achou = true;
                }
                    
            }

            if(!achou)
                Console.WriteLine($"O Veículo {nomeBusca} não existe em nosso sistema");



            Console.ReadKey();
        }
    }
}

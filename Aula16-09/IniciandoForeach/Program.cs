using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachComSplit();
        }

        private static void IniciandoForeach()
        {
            Console.WriteLine("Informe o texto: ");
            var texto = Console.ReadLine();

            foreach (var item in texto)
            {
                if (item == 'a')
                    continue;
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Metodo para busca com split informando nome
        /// </summary>
        private static void ForeachComSplit()
        {
            Console.WriteLine("Digite seu nome: ");
            var nome = Console.ReadLine();
            var texto = $@"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção;e;vamos;colocar;isto;{nome};para;depois;usar;com;o;replace";
            Console.WriteLine("Informe a palavra para realizar a busca: ");
            var palavra = Console.ReadLine();
            var textoSplit = texto.Split(';');
            var achou = false;
            foreach(var item in textoSplit)
            {

                if (palavra == item)
                {
                    Console.WriteLine("Palavra encontrada com sucesso!");
                    achou = true;
                }
                    
            }
            if(!achou)
                Console.WriteLine("Palavra não encontrada ):");
            Console.WriteLine(textoSplit.Length);
            Console.ReadKey();
        }

        private static void ForeachSplitList()
        {
            var conteudo = "nome:Douglas,idade:24;nome:Giomar,idade:54;nome:Anderson,idade:20";
            var listaDeInformacoes = conteudo.Split(';');


            Console.WriteLine("Usuarios: " );
            foreach (var item in listaDeInformacoes)
            {
                Console.Write(item.Split(','));
            }



            Console.ReadKey();
        }
    }
}

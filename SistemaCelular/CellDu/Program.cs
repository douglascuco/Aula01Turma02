using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCelulares.Controller;
using BibliotecaCelulares.Model;

namespace CellDu
{
    

    class Program
    {
        static CelularesController controller = new CelularesController();
        static string modeloCelular = "Id:{0,-5} || Marca:{1,-20} || Modelo:{2,-20} || Valor: {3,-5}";
        static void Main(string[] args)
        {
            MenuSistema();
        }

        public static void InserirCelular()
        {
                Console.WriteLine("-- Inserir Celular --");
                Console.WriteLine("Digite a Marca do Celular");
                var marca = Console.ReadLine();
                Console.WriteLine("Digite o Modelo do Celular");
                var modelo = Console.ReadLine();
                Console.WriteLine("Digite o valor do Celular");
                var preco = double.Parse(Console.ReadLine());
                var resultado = controller.InserirCelular(new Celular() { Marca = marca, Model = modelo, Preco = preco });

                if (resultado)
                    Console.WriteLine("Celular Inserido com sucesso");
                else
                    Console.WriteLine("ERRO ao inserir o celular, verifique as informações Utilizadas");
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
                Console.ReadKey(true);
                Console.Clear();
        }

        public static void MenuSistema()
        {
            var opcao = int.MinValue;
            
            while(opcao != 0)
            {
                Console.WriteLine("------BEM VINDO-------");
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir Celular");
                Console.WriteLine("2 - Mostrar Celulares");
                Console.WriteLine("3 - Atualizar Celular");
                Console.WriteLine("4 - Remover Celular");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());

                switch (opcao)
                {
                    case 1:
                        InserirCelular();
                        break;

                    case 2:
                        MostrarCelulares();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        AtualizarCelular();
                        break;

                    case 4:
                        RemoverCelular();
                        break;

                    default:
                        Console.WriteLine("Opção Invalida");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;

                    case 0:
                        break;
                }

            }
        }

        public static void MostrarCelulares()
        {
            Console.WriteLine("-- Mostrar Celulares --");
            controller.GetCelulares().ToList<Celular>().ForEach(x => Console.WriteLine(string.Format(modeloCelular, x.Id, x.Marca, x.Model, x.Preco.ToString("C"))));
        }

        public static void AtualizarCelular()
        {
            Console.WriteLine("-- Atualizar Celular --");
            MostrarCelulares();
            Console.WriteLine("Digite o ID do celular que Deseja Alterar!!");
            var id = int.Parse(Console.ReadLine());

            var celular = controller.GetCelulares().FirstOrDefault(x => x.Id == id);

            if(celular == null)
            {
                Console.WriteLine("ID do celular não existe");
                return;
            }
               

            Console.WriteLine("Digite a Marca do Celular");
            celular.Marca = Console.ReadLine();
            Console.WriteLine("Digite o Modelo do Celular");
            celular.Model = Console.ReadLine();
            Console.WriteLine("Digite o valor do Celular");
            celular.Preco = double.Parse(Console.ReadLine());


            var resultado = controller.AtualizarCelular(celular);

            if (resultado)
                Console.WriteLine("Celular Atualizado com Sucesso!!!");
            else
                Console.WriteLine("Erro ao Atualizar celular, confira os dados inseridos");

            Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
            Console.ReadKey(true);
            Console.Clear();
        }

        public static void RemoverCelular()
        {
            Console.WriteLine("-- Remover Celulares --");
            MostrarCelulares();
            Console.WriteLine("Digite o Id do celular que deseja remover");
            var id = int.Parse(Console.ReadLine());
            if (controller.RemoverCelular(id))
                Console.WriteLine("Celular Removido com Sucesso!!");
            else
                Console.WriteLine("Erro ao remover Celular!");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
            Console.ReadKey(true);
            Console.Clear();
        }
        
    }
}

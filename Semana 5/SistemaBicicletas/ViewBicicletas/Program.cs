using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaBicicletas.Controller;
using BibliotecaBicicletas.Model;
using Excel = Microsoft.Office.Interop.Excel;

namespace ViewBicicletas
{
    class Program
    {   
        static BicicletaController controller = new BicicletaController();
        static string modeloBicicleta = "Id:{0,-5} || Marca:{1,-30} || Modelo:{2,-30} || Valor: {3,-5}";

        static void Main(string[] args)
        {
            MenuSistema();
        }

        public static void MenuSistema()
        {
            var opcao = int.MinValue;

            while (opcao != 0)
            {
                Console.WriteLine("------BEM VINDO-------");
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir Bicicleta");
                Console.WriteLine("2 - Mostrar Bicicletas");
                Console.WriteLine("3 - Atualizar Bicileta");
                Console.WriteLine("4 - Remover Bicicleta");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());

                switch (opcao)
                {
                    case 1:
                        InserirBicicleta();
                        break;

                    case 2:
                        MostrarBicicletas();
                        Console.WriteLine("Deseja Imprimir esses valores em uma planilha? (1)sim");
                        var listaBici = controller.GetBicicletas().OrderByDescending(x => x.Valor).ToList<Bicicleta>();
                        var resultado = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                        if (resultado == 1)
                            CriarPlanilhaExcel(listaBici);
                        Console.Clear();
                        break;

                    case 3:
                        AtualizarBicicleta();
                        break;

                    case 4:
                        RemoverBicicleta();
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

        public static void InserirBicicleta()
        {
            Console.WriteLine("-- Inserir Bicicleta --");
            Console.WriteLine("Digite a Marca");
            var marca = Console.ReadLine();
            Console.WriteLine("Digite o Modelo");
            var modelo = Console.ReadLine();
            Console.WriteLine("Digite o valor");
            var preco = double.Parse(Console.ReadLine());
            var resultado = controller.InserirBicicleta(new Bicicleta() { Marca = marca, Modelo = modelo, Valor = preco });

            if (resultado)
                Console.WriteLine("Bicicleta inserida com sucesso");
            else
                Console.WriteLine("ERRO ao inserir o bicicleta, verifique as informações Utilizadas");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
            Console.ReadKey(true);
            Console.Clear();
        }

        public static void MostrarBicicletas()
        {
            Console.WriteLine("-- Mostrar Bicicleta --");
            var listaBici = controller.GetBicicletas().OrderByDescending(x => x.Valor).ToList<Bicicleta>();
            listaBici.ForEach(x => Console.WriteLine(string.Format(modeloBicicleta, x.Id, x.Marca, x.Modelo, x.Valor.ToString("C"))));

            var somaTotal = controller.GetBicicletas().Sum(x => x.Valor);
            Console.WriteLine($"Valor Total das Bicicletas: {somaTotal}");
        }

        public static void AtualizarBicicleta()
        {
            Console.WriteLine("-- Atualizar Bicicleta --");
            MostrarBicicletas();
            Console.WriteLine("Digite o ID da bicicleta que Deseja Alterar!!");
            var id = int.Parse(Console.ReadLine());

            var bicicleta = controller.GetBicicletas().FirstOrDefault(x => x.Id == id);

            if (bicicleta == null)
            {
                Console.WriteLine("ID da bicicleta não existe");
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
                Console.ReadKey(true);
                Console.Clear();
                return;
            }


            Console.WriteLine("Digite a Marca");
            bicicleta.Marca = Console.ReadLine();
            Console.WriteLine("Digite o Modelo");
            bicicleta.Modelo = Console.ReadLine();
            Console.WriteLine("Digite o valor");
            bicicleta.Valor = double.Parse(Console.ReadLine());


            var resultado = controller.AtualizarBicicleta(bicicleta);

            if (resultado)
                Console.WriteLine("Bicicleta Atualizada com Sucesso!!!");
            else
                Console.WriteLine("Erro ao Atualizar bicicleta, confira os dados inseridos");

            Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
            Console.ReadKey(true);
            Console.Clear();
        }

        public static void RemoverBicicleta()
        {
            Console.WriteLine("-- Remover Bicicleta --");
            MostrarBicicletas();
            Console.WriteLine("Digite o Id da biciclta que deseja remover");
            var id = int.Parse(Console.ReadLine());
            if (controller.RemoverBicicleta(id))
                Console.WriteLine("Bicicleta Removido com Sucesso!!");
            else
                Console.WriteLine("Erro ao remover Bicicleta!");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
            Console.ReadKey(true);
            Console.Clear();
        }

        private static void CriarPlanilhaExcel(List<Bicicleta> tabelaBicicleta)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range aRange;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 1] = "ID";
            xlWorkSheet.Cells[1, 2] = "Marca";
            xlWorkSheet.Cells[1, 3] = "Modelo";
            xlWorkSheet.Cells[1, 4] = "Valor";
            for (int i = 1; i <= tabelaBicicleta.Count; i++)
            {
                xlWorkSheet.Cells[i + 1, 1] = tabelaBicicleta[i - 1].Id.ToString();
                xlWorkSheet.Cells[i + 1, 2] = tabelaBicicleta[i - 1].Marca;
                xlWorkSheet.Cells[i + 1, 3] = tabelaBicicleta[i - 1].Modelo;
                xlWorkSheet.Cells[i + 1, 4] = tabelaBicicleta[i - 1].Valor.ToString("C");
            }
            var x = tabelaBicicleta.Count + 2;
            xlWorkSheet.Cells[x, 2] = "Soma total do valor das bicicletas: ";
            xlWorkSheet.Cells[x, 3] = tabelaBicicleta.Sum(y => y.Valor);
            xlWorkSheet.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            aRange = xlWorkSheet.get_Range("A1", "E100");
            aRange.Columns.AutoFit();
            var random = DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + DateTime.Now.Day.ToString();
            xlWorkBook.SaveAs($"ListaBicicleta{random}.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine($"\r\nConcluido, arquivo salvo em '{caminho}\\ListaBicicleta{random}.xls'");
            Console.ReadKey();
        }
    }   
}

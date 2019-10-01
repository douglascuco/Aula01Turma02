using ExercícioLinq.BD;
using ExercícioLinq.Controller;
using ExercícioLinq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExercícioLinq
{
    class Program
    {
        static CarroController carroController = new CarroController();
        static void Main(string[] args)
        {
            MenuVendas();
        }

        /// <summary>
        /// metodo para agregar os outros metodos
        /// </summary>
        private static void MenuVendas()
        {
            Console.WriteLine("---------------BEM VINDO--------------");
            Console.WriteLine("Mostrando tabela das vendas:");
            MostrarTabela();

            Console.WriteLine("Informe o numero do mês que deseja saber sobre a venda");
            
            var mesVenda = ValidaStringToInt();
            while(mesVenda > 12 || mesVenda < 1)
            {
                Console.WriteLine("CARACTER INVALIDO");
                Console.WriteLine("Digite APENAS NÚMEROS entre 1 e 12");
                mesVenda = int.Parse(Console.ReadLine());
            }
           // if (mesVenda > 12)
               
            Console.Clear();

            Console.WriteLine($"Listando Informações das vendas do mes {mesVenda}");
            VendasDoMes(mesVenda);
            MostrarSomaTotalMes(mesVenda);
            MostrarMediaVendasMes(mesVenda);
            Console.WriteLine("Deseja criar uma tabela excel com os dados informados? (1 para sim)");
            if(int.TryParse(Console.ReadKey().KeyChar.ToString(), out int resposta))
                if(resposta == 1)CriarPlanilhaExcel(carroController.MostraVendasUsuario(mesVenda), mesVenda);
        }

        /// <summary>
        /// metodo para mostrar toda a tabela de vendas
        /// </summary>
        private static void MostrarTabela()
        {
            carroController.MostraVendas().ForEach(x => ImprimeInformacoes(x));

        }

        /// <summary>
        /// Metodo que mostra na tela as vendas do mes escolhido
        /// </summary>
        /// <param name="mesVenda"> numero inteiro do mes escolhido</param>
        private static void VendasDoMes(int mesVenda)
        {
            carroController.MostraVendasUsuario(mesVenda).ForEach(x => ImprimeInformacoes(x)) ;
        }
        
        /// <summary>
        /// Mostra ao usuario a soma total dos valores de venda do mes selecionado
        /// </summary>
        /// <param name="mesVenda">mes em que se deseja saber a soma total de vendas</param>
        private static void MostrarSomaTotalMes(int mesVenda)
        {
            Console.WriteLine($"Soma total das vendas do mes: {carroController.MostraVendasUsuario(mesVenda).Sum(x => x.Valor * x.Quantidade).ToString("C")}");
        }

        /// <summary>
        /// Mostra ao usuario a média de venda do mes selecionado
        /// </summary>
        /// <param name="mesVenda">mes selecionado</param>
        private static void MostrarMediaVendasMes(int mesVenda)
        {
            Console.WriteLine($"Media das vendas do mes: { carroController.MostraVendasUsuario(mesVenda).Average(x => (x.Valor * x.Quantidade)).ToString("C")}");
        }

        /// <summary>
        /// Metodo para criar uma planilha do excel com as informações gerada pelos metodos venda do mes
        /// mostrarSomatotalMes e MostrarMediaVendasMes
        /// </summary>
        /// <param name="tabelaVendas">A tabela das vendas do mes</param>
        /// <param name="mesVenda">o mes escolhido para as vendas</param>
        private static void CriarPlanilhaExcel(List<VendaCarro> tabelaVendas, int mesVenda)
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
            xlWorkSheet.Cells[1, 2] = "Nome";
            xlWorkSheet.Cells[1, 3] = "Valor";
            xlWorkSheet.Cells[1, 4] = "Quantidade";
            xlWorkSheet.Cells[1, 5] = "Data da Venda";
            for (int i = 1; i <= tabelaVendas.Count; i++)
            {
                xlWorkSheet.Cells[i + 1, 1] = tabelaVendas[i-1].Id.ToString() ;
                xlWorkSheet.Cells[i + 1, 2] = tabelaVendas[i-1].Nome ;
                xlWorkSheet.Cells[i + 1, 3] = tabelaVendas[i-1].Valor.ToString("C");
                xlWorkSheet.Cells[i + 1, 4] = tabelaVendas[i-1].Quantidade.ToString();
                xlWorkSheet.Cells[i + 1, 5] = tabelaVendas[i-1].DataVenda.ToShortDateString();
            }
            var x = tabelaVendas.Count + 2;
            xlWorkSheet.Cells[x, 2] = "Soma total das vendas do mes: ";
            xlWorkSheet.Cells[x, 3] = carroController.MostraVendasUsuario(mesVenda).Sum(y => y.Valor * y.Quantidade).ToString("C");
            xlWorkSheet.Cells[x+1, 2] = "Media das vendas do mes: ";
            xlWorkSheet.Cells[x+1, 3] = carroController.MostraVendasUsuario(mesVenda).Average(y => (y.Valor * y.Quantidade)).ToString("C");
            xlWorkSheet.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            aRange = xlWorkSheet.get_Range("A1", "E100");
            aRange.Columns.AutoFit();
            var random = DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + DateTime.Now.Day.ToString() ;
            xlWorkBook.SaveAs($"arquivoMes{mesVenda}_{random}.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine($"\r\nConcluido, arquivo salvo em '{caminho}\arquivoMes{mesVenda}_{random}.xls'");
            Console.ReadKey();
        }

        /// <summary>
        /// Valida uma string para que ela seja inteira
        /// </summary>
        /// <returns>retorna em int o valor que contia na string</returns>
        private static int ValidaStringToInt()
        {
            var valido = false;
            int resposta = 0;
            while (!valido)
            {
                if (int.TryParse(Console.ReadLine(), out resposta))
                    valido = true;
                else
                    Console.WriteLine("Digite APENAS numeros");
            }
            return resposta;
        }

        /// <summary>
        /// Imprime na tela as informações da Classe VendaCarro passada
        /// </summary>
        /// <param name="x">Classe VendaCarro é passada</param>
        private static void ImprimeInformacoes(VendaCarro x)
        {
            var modeloTabela = "ID: {0,-5} Nome Carro: {1,-35} Valor: {2,-10} Quantidade: {3,-5} Data Venda: {4,-10}";
            Console.WriteLine(string.Format(modeloTabela, x.Id, x.Nome, x.Valor.ToString("C"), x.Quantidade, x.DataVenda.ToShortDateString()));
        }
    }
}

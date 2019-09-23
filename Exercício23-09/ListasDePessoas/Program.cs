using ListasDePessoas.Controller;
using ListasDePessoas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDePessoas
{
    class Program
    {
        /*
            1  - Listar estas informações em ordem crescente "Pelo nome" e decrescente  "Pela data de nascimento"
            2  - Listar as pessoas que contem mais de 500 reais na carteira 
            3  - Listar as pessoas com mais de 18 anos - Bônus
            4  - Listar as pessoas com menos de 16 anos - Bônus        */

        static PessoaController pessoasController = new PessoaController();

        static void Main(string[] args)
        {
            MostrarOrdemPeloNome();
            MostrarOrdemDecPelaDataNasc();
            PessoasMaisDe500();
            PessoasMaiorIdade();
            PessoasMenorDe16();
        }

        private static void MostrarOrdemPeloNome()
        {
            Console.Clear();
            Console.WriteLine("ORDEM CRESCENTE DO NOME DAS PESSOAS");

            var ordemPeloNome = pessoasController.MostraListaPessoas().OrderBy(x => x.Nome).ToList<Pessoa>();
            ordemPeloNome.ForEach(i => Console.WriteLine($"Id: {i.Id} || Nome: {i.Nome} || Data de Nascimento: {i.DataNasc.ToShortDateString()} || Salário: {i.Carteira.ToString("C")}"));

            Console.ReadKey();
        }

        private static void MostrarOrdemDecPelaDataNasc()
        {
            Console.Clear();
            Console.WriteLine("ORDEM DECRESCENTE DA DATA DE NASCIMENTO");

            var ordemPelaData = pessoasController.MostraListaPessoas().OrderByDescending(x => x.DataNasc).ToList<Pessoa>();
            ordemPelaData.ForEach(i => Console.WriteLine($"Id: {i.Id} || Nome: {i.Nome} || Data de Nascimento: {i.DataNasc.ToShortDateString()} || Salário: {i.Carteira.ToString("C")}"));

            Console.ReadKey();
        }

        private static void PessoasMaisDe500()
        {
            Console.Clear();
            Console.WriteLine("PESSOAS COM MAIS DE R$ 500,00 NA CARTEIRA");

            var pessoasMaisSalario = pessoasController.MostraListaPessoas().Where(i => i.Carteira > 500).ToList<Pessoa>();
            pessoasMaisSalario.ForEach(i => Console.WriteLine($"Id: {i.Id} || Nome: {i.Nome} || Data de Nascimento: {i.DataNasc.ToShortDateString()} || Salário: {i.Carteira.ToString("C")}"));

            Console.ReadKey();
        }

        private static void PessoasMaiorIdade()
        {
            Console.Clear();
            Console.WriteLine("PESSOAS MAIORES DE 18 ANOS");
            var pessoasMaior18 = from p in pessoasController.MostraListaPessoas()
                                 where CalcularIdade(p.DataNasc, DateTime.Now) > 17
                                 select p;
            pessoasMaior18.ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id: {i.Id} || Nome: {i.Nome} || Data de Nascimento: {i.DataNasc.ToShortDateString()} || Salário: {i.Carteira.ToString("C")}"));

            Console.ReadKey();
        }

        private static void PessoasMenorDe16()
        {
            Console.Clear();
            Console.WriteLine("PESSOAS MENORES DE 16 ANOS");

            var pessoasMenor16 = from p in pessoasController.MostraListaPessoas()
                                 where CalcularIdade(p.DataNasc, DateTime.Now) < 17
                                 select p;
            pessoasMenor16.ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id: {i.Id} || Nome: {i.Nome} || Data de Nascimento: {i.DataNasc.ToShortDateString()} || Salário: {i.Carteira.ToString("C")}"));

            Console.ReadKey();
        }

        private static int CalcularIdade(DateTime dataNascimento, DateTime dataComparacao)
        {
            int anos = dataComparacao.Year - dataNascimento.Year;

            if (dataComparacao.Month < dataNascimento.Month ||
                (dataComparacao.Month == dataNascimento.Month &&
                 dataComparacao.Day < dataNascimento.Day))
                anos--;

            return anos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoEntity
{
    class Program
    {

        static PessoaController pessoaController = new PessoaController();

        static void Main(string[] args)
        {

            pessoaController.AddPessoa(
                new Pessoa()
                {
                    Nome = Console.ReadLine()
                }
            ) ;


            pessoaController.GetPessoas().ToList<Pessoa>().ForEach(x => Console.WriteLine(x.Nome));


            Console.ReadKey();
        }
    }
}

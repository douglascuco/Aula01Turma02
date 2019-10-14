using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoClasseLibrary.Model;
using ProjetoClasseLibrary.Controller;

namespace AcessandoProjeto
{
    class Program
    {

        static AlunoController alunoController = new AlunoController();

        static void Main(string[] args)
        {
            MenuSistema();
        }

        public static void MenuSistema()
        {
            var resposta = 99;
            while (resposta != 0)
            {
                var modelo = "Nome:{0,-30} || Idade:{1,-5}";
                Console.Clear();
                Console.WriteLine("---------Olá, boa tarde! ----------");
                Console.WriteLine("---------Menu do Sistema-----------");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Mostrar Alunos Cadastrados");
                Console.WriteLine("0 - Sair");
                if (int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out int respostaParse))
                    resposta = respostaParse;
                else
                {
                    Console.WriteLine("UTILIZE APENAS NUMEROS");
                    Console.ReadKey(true);
                }


                switch (resposta)
                {
                    case 1:
                        Console.Clear();
                        AdicionarAluno();
                        alunoController.SalvarDB();
                        break;
                    case 2:
                        Console.Clear();
                        alunoController.GetAlunos().ToList<Aluno>().ForEach(x => Console.WriteLine(string.Format(modelo, x.Nome, x.Idade)));
                        Console.ReadKey(true);
                        break;
                    case 0:
                        break;
                }


            }

        }

        public static void AdicionarAluno()
        {
            Console.WriteLine("Digite o Nome do Aluno que deseja inserir no banco de dados: ");
            var nomeAluno = Console.ReadLine();
            Console.WriteLine("Digite a idade do Aluno: ");
            if (int.TryParse(Console.ReadLine(), out int idadeAluno))
            {
                alunoController.AddPessoa(new Aluno() { Nome = nomeAluno, Idade = idadeAluno });
                Console.WriteLine("Aluno cadastrado com sucesso!!!");
            }
            else
                Console.WriteLine("APENAS NUMEROS NA IDADE");
            Console.ReadKey(true);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCadastroPessoas.Model;

namespace SistemaCadastroPessoas
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MostrarLista(CadastrarPessoa());

            Console.ReadKey();
        }

        private static List<Pessoa> CadastrarPessoa()
        {
            var listaPessoas = new List<Pessoa>();
            var resposta = "1";
            while(resposta == "1")
            {
                var passou = false;
                var modeloPessoa = new Pessoa();
                Console.WriteLine("Digite o seu nome: ");
                modeloPessoa.Nome = Console.ReadLine();
                while (!passou)
                {
                    Console.WriteLine("Digite a sua idade: ");
                    if (int.TryParse(Console.ReadLine().Replace(" ", ""), out int idade))
                    {
                        modeloPessoa.Idade = idade;
                        passou = true;
                    }
                    else
                    {
                        Console.WriteLine("Idade Invalida");
                        Console.WriteLine("Digite apenas números inteiros");
                    }
                }
                passou = false;
                while (!passou)
                { 

                    Console.WriteLine("Digite seu sexo M(masculino), F(feminino) ou 0(outro)");
                    var sexo = char.Parse(Console.ReadKey().KeyChar.ToString().ToUpper());
                    if (sexo == 'M' || sexo == 'F' || sexo == '0')
                    {
                        modeloPessoa.Sexo = sexo;
                        passou = true;
                    }
                    else
                    {
                        Console.WriteLine("\r\nCaracter Invalido");
                        Console.WriteLine("Digite apenas a inicial do sexo apresentada");
                    }
                }
                passou = false;

                Console.WriteLine("\r\nDigite sua altura: ");
                modeloPessoa.Altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu RG (deve conter 7 numeros sem pontos, hifen ou espaços): ");
                modeloPessoa.RG = int.Parse(Console.ReadLine());
                while (modeloPessoa.RG.ToString().Length != 7)
                {
                    Console.WriteLine("-----RG INVALIDO!!!-----");
                    Console.WriteLine("Digite seu RG (deve conter 7 numeros sem pontos, hifen ou espaços): ");
                    modeloPessoa.RG = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Digite seu CPF (deve conter 11 numeros sem pontos, hifen ou espaços): ");
                modeloPessoa.CPF = Console.ReadLine();
                while (modeloPessoa.CPF.Length != 11)
                {
                    Console.WriteLine("-----CPF INVALIDO!!!-----");
                    Console.WriteLine("Digite seu CPF (deve conter 11 numeros sem pontos, hifen ou espaços): ");
                    modeloPessoa.CPF = Console.ReadLine();
                }
                listaPessoas.Add(modeloPessoa);
                Console.WriteLine("Olá, deseja cadastrar mais uma pessoa? Tecle 1 para sim ou outra tecla para sair");
                resposta = Console.ReadLine();
            }

            return listaPessoas;


        }



        private static void MostrarLista(List<Pessoa> listaPessoas)
        {
            listaPessoas.ForEach(i => Console.WriteLine($"Nome: {i.Nome} Idade: {i.Idade} Sexo: {i.Sexo} Altura: {i.Altura} RG: {i.RG} CPF: {i.CPF}"));
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestoDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lista de Fruta
            var cestaDeFrutas = new List<Fruta>();

            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });
            
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 120.66
            });
            
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Banana",
                Cor = "Amarelo",
                Peso = 45.5
            });
            #endregion

            cestaDeFrutas.OrderByDescending(x => x.Id ).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Cor: {i.Cor} Peso: {i.Peso}"));

            Console.WriteLine("------------------------------------------");

            var filtro = cestaDeFrutas.Where(x => x.Peso > 100).OrderBy(x => x.Nome);
            filtro.ToList<Fruta>().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Cor: {i.Cor} Peso: {i.Peso}"));




            Console.ReadKey(true);
        }
    }
}

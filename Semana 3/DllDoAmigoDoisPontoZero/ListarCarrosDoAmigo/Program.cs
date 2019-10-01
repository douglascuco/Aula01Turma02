using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCarro.Model;
using SistemaCarro.Controller;


namespace ListarCarrosDoAmigo
{
    class Program
    {
        static CarroController carroController = new CarroController();

        static void Main(string[] args)
        {
            carroController.RetornaCarros().ForEach(x => Console.WriteLine(string.Format("Id: {0,-5} Marca: {1, -15} Modelo: {2,-15} Ano: {4, -5} Cilindradas: {3,-5} Portas: {5,-5}",x.Id,x.Marca,x.Modelo,x.Cilindradas,x.Ano,x.Portas)));

            Console.ReadKey();
        }
    }
}

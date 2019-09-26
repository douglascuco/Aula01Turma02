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
            carroController.RetornaCarros().ForEach(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: {x.Modelo}"));

            Console.ReadKey();
        }
    }
}

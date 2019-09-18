using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class MostrarCarros
    {
        /// <summary>
        /// Mostra lista de carros cadastrados
        /// </summary>
        public void MostrarMarcas()
        {
            var listaCarros = new List<string>()
            {
                "Toyota",
                "BMW",
                "Volkswage",
                "Mercedes-Benz",
                "Honda" ,
                "Nissan" ,
                "Ford"
            };
            Console.WriteLine("Lista de marcas de carro Cadastradas: ");
            foreach (var item in listaCarros)
            {
                Console.WriteLine(item);
            }
        }
    }
}

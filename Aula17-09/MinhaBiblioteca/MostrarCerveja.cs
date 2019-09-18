using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class MostrarCerveja
    {
        /// <summary>
        /// Mostra uma lista das cervejas cadastradas
        /// </summary>
        public void MostrarCervejas()
        {
            var listaCerveja = new List<string>();
            var cervejas = (@"Antarctica Sub Zero,Antarctica,Beck's,Brahma,Brahma Zero,Bohemia,Brahma Light,Brahma Extra,Brahma Bier,Brahma Fresh,Budweiser,Caracu,Colorado,Corona,Polar,President,Puerto del Mar,Quilmes,Serramalte,Serrana,Skol,Skol Hops,Skol 360,Skol Beats Senses,Skol Beats Spirit,Skol Beats Secret,Skol Ultra,Skol Puro Malte,Samson,Stella Artois,Wäls").Split(',');
            for (int i = 0; i < cervejas.Length; i++)
            {
                listaCerveja.Add(cervejas[i]);
            }
            Console.WriteLine("Lista de Cervejas da AMBEV Cadastradas: ");
            foreach (var item in listaCerveja)
            {
                Console.WriteLine(item);
            }
        }

    }
}

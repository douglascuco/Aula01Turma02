using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        public List<Cerveja> Cervejas { get; set; }
        public int contador { get; set; } = 0;


        public SistemaCervejaContext()
        {
            Cervejas = new List<Cerveja>();
            Cervejas.Add(new Cerveja {Id = contador++, Nome = "Heineken", Litros = 0.35, Alcool = 4.7, Valor = 3.95 });
            Cervejas.Add(new Cerveja {Id = contador++, Nome = "Budweiser", Litros = 0.35, Alcool = 3.2, Valor = 4.20 });
            Cervejas.Add(new Cerveja {Id = contador++, Nome = "Stella Artois", Litros = 0.285, Alcool = 3.5, Valor = 2.99 });
            Cervejas.Add(new Cerveja {Id = contador++, Nome = "Skoll", Litros = 0.35, Alcool = 5.2, Valor = 2.25 });
            Cervejas.Add(new Cerveja {Id = contador++, Nome = "Brahma", Litros = 0.3, Alcool = 5, Valor = 2.5 });
        }
    }
}

using ExercícioLinq.BD;
using ExercícioLinq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioLinq.Controller
{
    public class CarroController
    {

        VendaCarroContext vendaCarroContext = new VendaCarroContext();

        public List<VendaCarro> MostraVendas()
        {
            return vendaCarroContext.listaVendaCarro.ToList(); ;
        }

        public List<VendaCarro> MostraVendasUsuario(int mesUsuario)
        {
            return vendaCarroContext.listaVendaCarro.Where(x => x.DataVenda.Month == mesUsuario).ToList();
        }

    }
}

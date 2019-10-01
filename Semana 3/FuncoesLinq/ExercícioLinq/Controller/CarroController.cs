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

        /// <summary>
        /// metodo que retorna toda a lista de vendas
        /// </summary>
        /// <returns>toda a lista de vendas</returns>
        public List<VendaCarro> MostraVendas()
        {
            return vendaCarroContext.listaVendaCarro.ToList(); ;
        }

        /// <summary>
        /// Metodo que retorna uma lista das vendas do mes que for colocado como parametro
        /// </summary>
        /// <param name="mesUsuario">Mes usado como parametro</param>
        /// <returns>retorna uma lista das vendas daquele mes</returns>
        public List<VendaCarro> MostraVendasUsuario(int mesUsuario)
        {
            return vendaCarroContext.listaVendaCarro.Where(x => x.DataVenda.Month == mesUsuario).ToList();
        }

    }
}

using ListagemDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Controller
{
    public class CarroController
    {
        /// <summary>
        /// Criando istancia da classe Context
        /// </summary>
        SistemasCarrosContext sistemasCarrosContext = new SistemasCarrosContext();


        /// <summary>
        /// Metodo para retornar os carros da Lista do context
        /// </summary>
        /// <returns></returns>
        public List<Carro> ListaCarros()
        {
            return sistemasCarrosContext.ListaCarros;
        }
    }
}

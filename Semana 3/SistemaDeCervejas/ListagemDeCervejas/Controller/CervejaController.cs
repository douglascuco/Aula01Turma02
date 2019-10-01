using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContext sistemaCervejaContext = new SistemaCervejaContext();

        /// <summary>
        /// metodo para retornar uma lista de cervejas 
        /// </summary>
        /// <returns>retornar uma lista de cervejas</returns>
        public List<Cerveja> RetornaListaCervejas()
        {
            return sistemaCervejaContext.Cervejas;
        }

        /// <summary>
        /// Metodo para adicionar um item tipo cerveja na lista
        /// </summary>
        /// <param name="cerveja"></param>
        public void AdicionaItensLista(Cerveja cerveja)
        {
            cerveja.Id = sistemaCervejaContext.contador++;
            sistemaCervejaContext.Cervejas.Add(cerveja);
        }


        /// <summary>
        /// metodo que retorna a soma dos valores de todas as cervejas
        /// </summary>
        /// <returns>retorna um valor em double da soma dos valores</returns>
        public double ValorTotalCervejas()
        {
            return sistemaCervejaContext.Cervejas.Sum(x => x.Valor);
        }
        
        /// <summary>
        /// metodo que retorna a soma total dos litros dos itens cadastrados
        /// </summary>
        /// <returns>retorna a soma dos valores em double</returns>
        public double LitrosTotalCervejas()
        {
            return sistemaCervejaContext.Cervejas.Sum(x => x.Litros);
        }

        /// <summary>
        /// metodo que retorna um tipo booleano se a pessoa vai presa ou não
        /// </summary>
        /// <param name="peso">parametro do peso da pessoa</param>
        /// <returns>retorna true caso ele esteja preso e false caso não</returns>
        public double FoiPreso(double peso)
        {
            //Litros no sangue = 8% do peso
            //quantidade de alcool na bebida = teor Alcoolico * litros
            //regra de 3 com o tanto de sangue com a quantidade de alcool da bebida
            var litrosDeSangue = peso * 0.08;
            var totalAlcool = sistemaCervejaContext.Cervejas.Sum(x => (x.Alcool/100) *x.Litros) * 0.79;
            var alcoolNoSangue = (totalAlcool * 100) / (litrosDeSangue);
            return alcoolNoSangue;
        }
        
    }
}

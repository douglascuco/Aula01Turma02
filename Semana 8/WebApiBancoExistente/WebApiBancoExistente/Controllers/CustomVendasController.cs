using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiBancoExistente.Models;

namespace WebApiBancoExistente.Controllers
{
    public partial class VendasController
    {
        [HttpGet]
        [Route("Api/Vendas/RelatorioAno/{Ano}")]
        public object RelatorioVendasAno(int ano)
        {
            var listVendas = db.Vendas.Where(x => x.DatInc.Year == ano).ToList();
            var listCarros = db.Carros.ToList();
            var conteudoVendas = from ven in listVendas
                                 join car in listCarros
                                 on ven.Carro equals car.Id
                                 select new
                                 {
                                     NomeCarro = car.Modelo,
                                     QuantidadeVenda = ven.Quantidade,
                                     ValorVenda = ven.Valor,
                                     DataVenda = ven.DatInc.ToShortDateString()
                                 };

            return conteudoVendas;

        }

        [HttpGet]
        [Route("Api/Vendas/RelatorioAnoPorUsuario/{Ano}/{IdUsuario}")]
        public object RelatorioVendasAnoPorUsuario(int ano, int idUsuario)
        {
            var listVendas = db.Vendas.Where(x => x.DatInc.Year == ano && x.UsuInc == idUsuario).ToList();
            var listCarros = db.Carros.ToList();
            var listUsuarios = db.Usuarios.ToList();
            var conteudoVendas = from ven in listVendas
                                 join car in listCarros
                                 on ven.Carro equals car.Id
                                 join usu in listUsuarios
                                 on ven.UsuInc equals usu.Id
                                 select new
                                 {
                                     NomeCarro = car.Modelo,
                                     QuantidadeVenda = ven.Quantidade,
                                     ValorVenda = ven.Valor,
                                     Vendedor = usu.Usuario1
                                 };

            return conteudoVendas;
        }

        [HttpGet]
        [Route("Api/Vendas/RelatorioMarca/{Ano}/{idMarca}")]
        public object RelatorioVendasPorMarca(int ano, int idMarca)
        {
            var listVendas = db.Vendas.Where(x => x.DatInc.Year == ano).ToList();
            var listCarros = db.Carros.ToList();
            var listMarcas = db.Marcas.Where(x => x.Id == idMarca).ToList();
            var conteudoVendas = from ven in listVendas
                                 join car in listCarros
                                 on ven.Carro equals car.Id
                                 join mar in listMarcas
                                 on car.Marca equals mar.Id
                                 orderby ven.Quantidade descending
                                 select new
                                 {
                                     NomeMarca = mar.Nome,
                                     QuantidadeVenda = ven.Quantidade,
                                     ValorVenda = ven.Valor,
                                     DataVenda = ven.DatInc.ToShortDateString()
                                 };

            return conteudoVendas;
        }
    }
}
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
            var listVendas = db.Vendas.ToList();
            var listCarros = db.Carros.ToList();
            var conteudoVendas = from ven in listVendas
                                 join car in listCarros
                                 on ven.Carro equals car.Id
                                 where ven.DatInc.Year == ano
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
            var listVendas = db.Vendas.ToList();
            var listCarros = db.Carros.ToList();
            var listUsuarios = db.Usuarios.ToList();
            var conteudoVendas = from ven in listVendas
                                 join car in listCarros
                                 on ven.Carro equals car.Id
                                 join usu in listUsuarios
                                 on ven.UsuInc equals usu.Id
                                 where ven.DatInc.Year == ano && ven.UsuInc == idUsuario
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
        [Route("Api/Vendas/RelatorioMarca/{idMarca}")]
        public object RelatorioVendasPorMarca(int idMarca)
        {
            var listVendas = db.Vendas.ToList();
            var listCarros = db.Carros.ToList();
            var listMarcas = db.Marcas.ToList();
            var conteudoVendas = from ven in listVendas
                                 join car in listCarros
                                 on ven.Carro equals car.Id
                                 join mar in listMarcas
                                 on car.Marca equals mar.Id
                                 where mar.Id == idMarca
                                 orderby ven.Quantidade descending
                                 select new
                                 {
                                     NomeMarca = mar.Nome,
                                     QuantidadeVenda = ven.Quantidade,
                                     ValorVenda = ven.Valor
                                 };

            return conteudoVendas;
        }
    }
}
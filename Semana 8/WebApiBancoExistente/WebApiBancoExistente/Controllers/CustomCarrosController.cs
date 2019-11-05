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
    public partial class CarrosController
    {

        [HttpGet]
        [Route("Api/Carros/CarrosUsuario/{id}")]
        public object CustomCarrosPorUsuario(int id)
        {
            var listUsuarios = db.Usuarios.ToList();
            var listCarros = db.Carros.ToList();

            var conteudoRetorno = from car in listCarros
                                  join usu in listUsuarios
                                  on car.UsuInc equals usu.Id
                                  where car.Id == id
                                  select new
                                  {
                                      IdCarro = car.Id,
                                      NomeCarro = car.Modelo,
                                      IdUsuario = usu.Id,
                                      NomeUsuario = usu.Usuario1
                                  };
            return conteudoRetorno;
        }

    }
}
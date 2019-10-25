using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculandoIdade.Controllers
{
    public class CalculoIdadeController : ApiController
    {

        [EnableCors(origins: "*", headers: "*", methods: "*")]

        public string Get(string nome, double peso, double altura)
        {
            var imc = peso / (altura * altura);
            return $"Olá {nome} seu imc é {imc.ToString("N2")} e ele foi calculado de acordo com sua Altura: {altura} e Peso:{peso}";
        }

    }
}

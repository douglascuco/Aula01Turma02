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
            var ideal = "";
            if (imc < 18.5)
                ideal = "Abaixo do peso";
            else if (imc < 24.9)
                ideal = "Peso normal";
            else if (imc < 29.9)
                ideal = "Sobrepeso";
            else if (imc < 34.9)
                ideal = "com Obesidade 1";
            else if (imc < 39.9)
                ideal = "com Obesidade 2";
            else if (imc > 40)
                ideal = "com Obesidade 3";


            return $"Olá {nome} seu imc é de '{imc.ToString("N2")}', você está {ideal}. \r\nCálculos de acordo com sua Altura: {altura}m e Peso: {peso}kg";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    public class SistemasCarrosContext
    {
        /// <summary>
        /// Lista de Carros
        /// </summary>
        public List<Carro> ListaCarros { get; set; }

        /// <summary>
        /// Construtor da Classe Context
        /// </summary>
        public SistemasCarrosContext()
        {
            ListaCarros = new List<Carro>();

            ListaCarros.Add(new Carro { Id = 1, Marca = "Audi", Modelo = "A4", Ano = 2000, Cilindradas = 800.50, Portas = 4});
            ListaCarros.Add(new Carro { Id = 2, Marca = "Fiat", Modelo = "Uno", Ano = 1995, Cilindradas = 20.8, Portas = 2});
            ListaCarros.Add(new Carro { Id = 3, Marca = "Ferrari", Modelo = "Spider", Ano = 2018, Cilindradas = 2999.99, Portas = 4});
            ListaCarros.Add(new Carro { Id = 4, Marca = "Chevrolet", Modelo = "Camaro", Ano = 2016, Cilindradas = 6162, Portas = 2});
            ListaCarros.Add(new Carro { Id = 5, Marca = "Mercedes-benz", Modelo = "Classe C", Ano = 2020, Cilindradas = 5200, Portas = 4});
            ListaCarros.Add(new Carro { Id = 6, Marca = "Renault", Modelo = "Sandero", Ano = 2015, Cilindradas = 1800, Portas = 4});
            ListaCarros.Add(new Carro { Id = 7, Marca = "Fiat", Modelo = "Mobi", Ano = 2019, Cilindradas = 2500.99, Portas = 4});
            ListaCarros.Add(new Carro { Id = 8, Marca = "Fiat", Modelo = "Doblo", Ano = 2010, Cilindradas = 890.74, Portas = 2});
            ListaCarros.Add(new Carro { Id = 9, Marca = "Audi", Modelo = "TT", Ano = 2017, Cilindradas = 5899, Portas = 2});
            ListaCarros.Add(new Carro { Id = 10, Marca = "Citroen", Modelo = "C3", Ano = 2012, Cilindradas = 1680, Portas = 4});
        }
    }
}

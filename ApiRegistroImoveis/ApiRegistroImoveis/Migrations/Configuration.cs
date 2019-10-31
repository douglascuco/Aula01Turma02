namespace ApiRegistroImoveis.Migrations
{
    using ApiRegistroImoveis.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<ApiRegistroImoveis.Models.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApiRegistroImoveis.Models.MigrationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            var listProprietarios = new List<Proprietario>() {
                new Proprietario(){
                    Nome = "Felipe",
                    DataDeNasc = DateTime.Parse("03/08/1992"),
                    Email = "contato@usysweb.com.br"
                },
                new Proprietario()
                {
                    Nome = "Giomar",
                    DataDeNasc = DateTime.Parse("24/01/1836"),
                    Email = "contato@pulsaopubmatico.org"
                }
            };

            listProprietarios.ForEach(s =>
                context.Proprietarios.AddOrUpdate(x => x.Nome, s)
            );

            context.SaveChanges();

            var listaImoveis = new List<Imovel>()
            {
                new Imovel(){
                    Cep = 89130000,
                    Bairro = "Tapajos",
                    Logradouro = "Rua Brasilia",
                    Municipio = "Indaial",
                    Numero = 210,
                    Complemento = "próximo ao carambas",
                    IdProprietario = context.Proprietarios
                                            .FirstOrDefault(x => x.Nome == "Felipe").Id
                },
                new Imovel(){
                    Cep = 89130000,
                    Bairro = "Tapajos",
                    Logradouro = "Rua Mina Gerais",
                    Municipio = "Indaial",
                    Numero = 856,
                    Complemento = "ao la do do bar do zeca",
                    IdProprietario = context.Proprietarios
                                            .FirstOrDefault(x => x.Nome == "Giomar").Id
                }
            };

            listaImoveis.ForEach(s =>
                context.Imoveis.AddOrUpdate(x => new { x.IdProprietario, x.Cep }, s)
            );

            context.SaveChanges();


        }
    }
}

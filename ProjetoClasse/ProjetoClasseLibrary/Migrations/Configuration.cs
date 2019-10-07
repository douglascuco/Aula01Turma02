namespace ProjetoClasseLibrary.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoClasseLibrary.Model.ProjetoContextBD>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ProjetoClasseLibrary.Model.ProjetoContextBD";
        }

        protected override void Seed(ProjetoClasseLibrary.Model.ProjetoContextBD context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

namespace ApiRegistroImoveis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContruindoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imovels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cep = c.Int(nullable: false),
                        Logradouro = c.String(),
                        Bairro = c.String(),
                        Municipio = c.String(),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(),
                        IdProprietario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proprietarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataDeNasc = c.DateTime(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proprietarios");
            DropTable("dbo.Imovels");
        }
    }
}

namespace ECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        IdClient = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        NumeroTel = c.Int(nullable: false),
                        Adresse = c.String(),
                    })
                .PrimaryKey(t => t.IdClient);
            
            CreateTable(
                "dbo.Commandes",
                c => new
                    {
                        IdCommande = c.Int(nullable: false, identity: true),
                        IdClient = c.Int(nullable: false),
                        IdCommercial = c.Int(nullable: false),
                        DateCom = c.String(),
                        code = c.String(),
                    })
                .PrimaryKey(t => t.IdCommande);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomPrenom = c.String(),
                        DateNaissance = c.String(),
                        Telephone = c.Int(nullable: false),
                        LogIn = c.String(),
                        Password = c.String(),
                        Role = c.Int(nullable: false),
                        IdCommercial = c.Int(),
                        Salaire = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        IdProduit = c.Int(nullable: false, identity: true),
                        Titre = c.String(),
                        Prix = c.Single(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.IdProduit);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produits");
            DropTable("dbo.Users");
            DropTable("dbo.Commandes");
            DropTable("dbo.Clients");
        }
    }
}

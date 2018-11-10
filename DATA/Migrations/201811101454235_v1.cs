namespace DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Chats");
            DropTable("dbo.Motifs");
            DropTable("dbo.Notifications");
            DropTable("dbo.Parcours");
            DropTable("dbo.PlusMeds");
            DropTable("dbo.Programmes");
            DropTable("dbo.Ratings");
            DropTable("dbo.Rapports");
            DropTable("dbo.RDVs");
            DropTable("dbo.Soins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Soins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idMed = c.Int(nullable: false),
                        soin = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.RDVs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idPatient = c.Int(nullable: false),
                        idMedecien = c.Int(nullable: false),
                        nom = c.String(),
                        prenom = c.String(),
                        date = c.DateTime(nullable: false),
                        ville = c.String(),
                        maladi = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Rapports",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idMed = c.Int(nullable: false),
                        idPet = c.Int(nullable: false),
                        picture = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        idPat = c.Int(nullable: false, identity: true),
                        idMed = c.Int(nullable: false),
                        nbrEtoile = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPat);
            
            CreateTable(
                "dbo.Programmes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idMed = c.Int(nullable: false),
                        idRdv = c.Int(nullable: false),
                        DateDebutR = c.String(),
                        DateFinR = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PlusMeds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDMed = c.Int(nullable: false),
                        specialieProfondu = c.String(),
                        Hopital = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Parcours",
                c => new
                    {
                        ParcoursID = c.String(nullable: false, maxLength: 128),
                        IDPatient = c.String(),
                        IdMedecin = c.String(),
                        NomMedecin = c.String(),
                        Specialite = c.String(),
                        Maladie = c.String(),
                        date = c.DateTime(nullable: false),
                        Etat = c.String(),
                        Justification = c.String(),
                        Adresse = c.String(),
                    })
                .PrimaryKey(t => t.ParcoursID);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idMedecin = c.Int(nullable: false),
                        idPatient = c.Int(nullable: false),
                        contenu = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Motifs",
                c => new
                    {
                        motifID = c.Int(nullable: false, identity: true),
                        idPatient = c.Int(nullable: false),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.motifID);
            
            CreateTable(
                "dbo.Chats",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idPat = c.Int(nullable: false),
                        idMed = c.Int(nullable: false),
                        contenu = c.String(),
                        date = c.DateTime(nullable: false),
                        etat = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
    }
}

namespace gestion_rendez_vous.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UpdateTableNames : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.rendezvous", "IdMoyenPaiement", "dbo.MoyenPaiements");
            DropIndex("dbo.rendezvous", new[] { "IdMoyenPaiement" });
            AddColumn("dbo.personnes", "DateNaissance", c => c.DateTime(precision: 0));
            AddColumn("dbo.rendezvous", "IdPatient", c => c.Int(nullable: false));
            AddColumn("dbo.rendezvous", "IdMedecin", c => c.Int(nullable: false));
            CreateIndex("dbo.rendezvous", "IdPatient");
            CreateIndex("dbo.rendezvous", "IdMedecin");
            AddForeignKey("dbo.rendezvous", "IdMedecin", "dbo.personnes", "IdU", cascadeDelete: true);
            AddForeignKey("dbo.rendezvous", "IdPatient", "dbo.personnes", "IdU", cascadeDelete: true);
            DropColumn("dbo.rendezvous", "IdMoyenPaiement");
            DropTable("dbo.MoyenPaiements");
        }

        public override void Down()
        {
            CreateTable(
                "dbo.MoyenPaiements",
                c => new
                {
                    IdMoyenPaiement = c.Int(nullable: false, identity: true),
                    libelle = c.String(unicode: false),
                })
                .PrimaryKey(t => t.IdMoyenPaiement);

            AddColumn("dbo.rendezvous", "IdMoyenPaiement", c => c.Int(nullable: false));
            DropForeignKey("dbo.rendezvous", "IdPatient", "dbo.personnes");
            DropForeignKey("dbo.rendezvous", "IdMedecin", "dbo.personnes");
            DropIndex("dbo.rendezvous", new[] { "IdMedecin" });
            DropIndex("dbo.rendezvous", new[] { "IdPatient" });
            DropColumn("dbo.rendezvous", "IdMedecin");
            DropColumn("dbo.rendezvous", "IdPatient");
            DropColumn("dbo.personnes", "DateNaissance");
            CreateIndex("dbo.rendezvous", "IdMoyenPaiement");
            AddForeignKey("dbo.RendezVous", "IdMoyenPaiement", "dbo.MoyenPaiements", "IdMoyenPaiement", cascadeDelete: true);
        }
    }
}
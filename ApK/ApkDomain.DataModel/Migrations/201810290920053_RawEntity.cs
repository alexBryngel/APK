namespace ApkDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RawEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RawItemEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nr = c.Int(nullable: false),
                        Artikelid = c.Int(nullable: false),
                        Varnummer = c.Int(nullable: false),
                        Namn = c.String(),
                        Namn2 = c.String(),
                        Prisinklmoms = c.Double(nullable: false),
                        Pant = c.Double(nullable: false),
                        Volymiml = c.Double(nullable: false),
                        PrisPerLiter = c.Double(nullable: false),
                        Saljstart = c.DateTime(nullable: false),
                        Utgått = c.Boolean(nullable: false),
                        Varugrupp = c.String(),
                        Typ = c.String(),
                        Stil = c.String(),
                        Forpackning = c.String(),
                        Forslutning = c.String(),
                        Ursprung = c.String(),
                        Ursprunglandnamn = c.String(),
                        Producent = c.String(),
                        Leverantor = c.String(),
                        Argang = c.Int(nullable: false),
                        Provadargang = c.String(),
                        Alkoholhalt = c.Boolean(nullable: false),
                        Sortiment = c.String(),
                        SortimentText = c.String(),
                        Ekologisk = c.Boolean(nullable: false),
                        Etiskt = c.Boolean(nullable: false),
                        EtisktEtikett = c.Boolean(nullable: false),
                        Koscher = c.Boolean(nullable: false),
                        RavarorBeskrivning = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RawItemEntities");
        }
    }
}

namespace ApkDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Double(nullable: false),
                        amount = c.Double(nullable: false),
                        alcohol = c.Double(nullable: false),
                        apk = c.Double(nullable: false),
                        personEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.personEntities", t => t.personEntity_Id)
                .Index(t => t.personEntity_Id);
            
            CreateTable(
                "dbo.personEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemEntities", "personEntity_Id", "dbo.personEntities");
            DropIndex("dbo.ItemEntities", new[] { "personEntity_Id" });
            DropTable("dbo.personEntities");
            DropTable("dbo.ItemEntities");
        }
    }
}

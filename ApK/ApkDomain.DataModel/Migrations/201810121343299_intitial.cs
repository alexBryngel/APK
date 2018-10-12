namespace ApkDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Double(nullable: false),
                        amount = c.Double(nullable: false),
                        alcohol = c.Double(nullable: false),
                        apk = c.Double(nullable: false),
                        personModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.personModels", t => t.personModel_Id)
                .Index(t => t.personModel_Id);
            
            CreateTable(
                "dbo.personModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemModels", "personModel_Id", "dbo.personModels");
            DropIndex("dbo.ItemModels", new[] { "personModel_Id" });
            DropTable("dbo.personModels");
            DropTable("dbo.ItemModels");
        }
    }
}

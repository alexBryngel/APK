namespace ApkDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemEntities", "varunummer", c => c.String());
            AddColumn("dbo.ItemEntities", "name2", c => c.String());
            AddColumn("dbo.ItemEntities", "volymiml", c => c.Double(nullable: false));
            AddColumn("dbo.ItemEntities", "varugrupp", c => c.String());
            AddColumn("dbo.ItemEntities", "typ", c => c.String());
            AddColumn("dbo.ItemEntities", "ursprungslandnamn", c => c.String());
            DropColumn("dbo.ItemEntities", "amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ItemEntities", "amount", c => c.Double(nullable: false));
            DropColumn("dbo.ItemEntities", "ursprungslandnamn");
            DropColumn("dbo.ItemEntities", "typ");
            DropColumn("dbo.ItemEntities", "varugrupp");
            DropColumn("dbo.ItemEntities", "volymiml");
            DropColumn("dbo.ItemEntities", "name2");
            DropColumn("dbo.ItemEntities", "varunummer");
        }
    }
}

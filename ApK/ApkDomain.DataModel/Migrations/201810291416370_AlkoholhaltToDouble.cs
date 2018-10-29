namespace ApkDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlkoholhaltToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.rawItemEntities", "Alkoholhalt", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.rawItemEntities", "Alkoholhalt", c => c.Boolean(nullable: false));
        }
    }
}

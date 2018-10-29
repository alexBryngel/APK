namespace ApkDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RawEntityUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RawItemEntities", "EtisktEtikett", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RawItemEntities", "EtisktEtikett", c => c.Boolean(nullable: false));
        }
    }
}

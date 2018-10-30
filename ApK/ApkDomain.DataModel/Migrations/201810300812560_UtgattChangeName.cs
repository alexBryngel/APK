namespace ApkDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UtgattChangeName : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.rawItemEntities", "Utgått", "Utgatt");            
        }
        
        public override void Down()
        {
            RenameColumn("dbo.rawItemEntities", "Utgatt", "Utgått");
        }
    }
}

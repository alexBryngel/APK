namespace ApkDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTabel : DbMigration
    {
        public override void Up()
        {
            RenameTable("dbo.RawItemEntities", "dbo.rawItemEntities");
        }
        
        public override void Down()
        {
            RenameTable("dbo.rawItemEntities", "dbo.RawItemEntities");
        }
    }
}

namespace ApkDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ItemEntities", "varunummer", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ItemEntities", "varunummer", c => c.String());
        }
    }
}

namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_content_deleted_value2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contents", "Value2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contents", "Value2", c => c.String());
        }
    }
}

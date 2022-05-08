namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Write_Title_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "Title");
        }
    }
}

namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Writer_Add_About : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "About", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "About");
        }
    }
}

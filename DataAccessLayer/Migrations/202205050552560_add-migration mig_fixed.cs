namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationmig_fixed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Description", c => c.String(maxLength: 1000));
            DropColumn("dbo.Categories", "Decription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Decription", c => c.String(maxLength: 1000));
            DropColumn("dbo.Categories", "Description");
        }
    }
}

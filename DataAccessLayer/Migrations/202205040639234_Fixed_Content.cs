﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixed_Content : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "Value2", c => c.String());
            AlterColumn("dbo.Contents", "Value", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contents", "Value", c => c.String(maxLength: 1000));
            DropColumn("dbo.Contents", "Value2");
        }
    }
}

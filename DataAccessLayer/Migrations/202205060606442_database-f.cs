namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databasef : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "Details", c => c.String());
            AlterColumn("dbo.Abouts", "Details2", c => c.String());
            AlterColumn("dbo.Abouts", "Image", c => c.String());
            AlterColumn("dbo.Abouts", "Image2", c => c.String());
            AlterColumn("dbo.Categories", "Description", c => c.String());
            AlterColumn("dbo.Writers", "Name", c => c.String());
            AlterColumn("dbo.Writers", "Surname", c => c.String());
            AlterColumn("dbo.Writers", "Image", c => c.String());
            AlterColumn("dbo.Writers", "Mail", c => c.String());
            AlterColumn("dbo.Writers", "Password", c => c.String());
            AlterColumn("dbo.Contacts", "UserName", c => c.String());
            AlterColumn("dbo.Contacts", "UserMail", c => c.String());
            AlterColumn("dbo.Contacts", "Subject", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Subject", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "UserMail", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "UserName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Writers", "Password", c => c.String(maxLength: 20));
            AlterColumn("dbo.Writers", "Mail", c => c.String(maxLength: 50));
            AlterColumn("dbo.Writers", "Image", c => c.String(maxLength: 50));
            AlterColumn("dbo.Writers", "Surname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Writers", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Categories", "Description", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Abouts", "Image2", c => c.String(maxLength: 100));
            AlterColumn("dbo.Abouts", "Image", c => c.String(maxLength: 100));
            AlterColumn("dbo.Abouts", "Details2", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Abouts", "Details", c => c.String(maxLength: 1000));
        }
    }
}

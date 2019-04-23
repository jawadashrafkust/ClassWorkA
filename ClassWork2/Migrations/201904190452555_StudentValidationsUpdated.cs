namespace ClassWork2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentValidationsUpdated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "FullName", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Students", "Address", c => c.String(maxLength: 200));
            AlterColumn("dbo.Students", "Phone", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Phone", c => c.String());
            AlterColumn("dbo.Students", "Address", c => c.String());
            AlterColumn("dbo.Students", "FullName", c => c.String());
        }
    }
}

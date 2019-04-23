namespace ClassWork2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentPhoneAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Phone");
        }
    }
}

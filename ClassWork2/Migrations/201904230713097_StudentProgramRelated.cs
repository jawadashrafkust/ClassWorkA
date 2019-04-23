namespace ClassWork2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentProgramRelated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "ProgramId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "ProgramId");
            AddForeignKey("dbo.Students", "ProgramId", "dbo.Programs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ProgramId", "dbo.Programs");
            DropIndex("dbo.Students", new[] { "ProgramId" });
            DropColumn("dbo.Students", "ProgramId");
            DropTable("dbo.Programs");
        }
    }
}

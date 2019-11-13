namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOfficeAssignmentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OfficeAssignments",
                c => new
                    {
                        InstructorId = c.Int(nullable: false),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.InstructorId)
                .ForeignKey("dbo.Instructor", t => t.InstructorId)
                .Index(t => t.InstructorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAssignments", "InstructorId", "dbo.Instructor");
            DropIndex("dbo.OfficeAssignments", new[] { "InstructorId" });
            DropTable("dbo.OfficeAssignments");
        }
    }
}

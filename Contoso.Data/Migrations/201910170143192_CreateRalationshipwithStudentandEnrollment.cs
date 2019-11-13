namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRalationshipwithStudentandEnrollment : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Enrollments", "StudentId");
            AddForeignKey("dbo.Enrollments", "StudentId", "dbo.Student", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Student");
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
        }
    }
}

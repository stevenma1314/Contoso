namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationshipwithCourseandDepartment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Department_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Department_Id");
            AddForeignKey("dbo.Courses", "Department_Id", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "Department_Id" });
            DropColumn("dbo.Courses", "Department_Id");
        }
    }
}

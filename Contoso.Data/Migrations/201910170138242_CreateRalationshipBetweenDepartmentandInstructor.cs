﻿namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRalationshipBetweenDepartmentandInstructor : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Departments", "InstructorId");
            AddForeignKey("dbo.Departments", "InstructorId", "dbo.Instructor", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "InstructorId", "dbo.Instructor");
            DropIndex("dbo.Departments", new[] { "InstructorId" });
        }
    }
}

namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleAndPersonRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonRoles",
                c => new
                    {
                        Person_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Person_Id, t.Role_Id })
                .ForeignKey("dbo.People", t => t.Person_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.Person_Id)
                .Index(t => t.Role_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.PersonRoles", "Person_Id", "dbo.People");
            DropIndex("dbo.PersonRoles", new[] { "Role_Id" });
            DropIndex("dbo.PersonRoles", new[] { "Person_Id" });
            DropTable("dbo.PersonRoles");
        }
    }
}

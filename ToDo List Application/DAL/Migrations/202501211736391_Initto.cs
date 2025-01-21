namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Status = c.String(nullable: false, maxLength: 50),
                        DueDate = c.DateTime(nullable: false),
                        Priority = c.String(nullable: false, maxLength: 50),
                        Category = c.String(nullable: false, maxLength: 50),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDoLists", "UserId", "dbo.Users");
            DropIndex("dbo.ToDoLists", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.ToDoLists");
        }
    }
}

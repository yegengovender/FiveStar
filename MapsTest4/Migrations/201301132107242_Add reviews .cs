namespace MapsTest4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addreviews : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Venues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Industry = c.String(),
                        Comments = c.String(),
                        XPos = c.Double(nullable: false),
                        YPos = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Venue_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Venues", t => t.Venue_Id)
                .Index(t => t.Venue_Id);
            
            DropTable("dbo.People");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropIndex("dbo.Reviews", new[] { "Venue_Id" });
            DropForeignKey("dbo.Reviews", "Venue_Id", "dbo.Venues");
            DropTable("dbo.Reviews");
            DropTable("dbo.Venues");
        }
    }
}

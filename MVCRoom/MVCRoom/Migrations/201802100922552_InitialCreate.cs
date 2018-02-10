namespace MVCRoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.RoomId);
            
            CreateTable(
                "dbo.Spearkers",
                c => new
                    {
                        RoomSpeakerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomSpeakerId)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Spearkers", "RoomId", "dbo.Rooms");
            DropIndex("dbo.Spearkers", new[] { "RoomId" });
            DropTable("dbo.Spearkers");
            DropTable("dbo.Rooms");
        }
    }
}

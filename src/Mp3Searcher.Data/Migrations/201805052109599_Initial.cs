namespace Mp3Searcher.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mp3FileLocation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(nullable: false, maxLength: 255),
                        Mp3File_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mp3File", t => t.Mp3File_Id)
                .Index(t => t.Mp3File_Id);
            
            CreateTable(
                "dbo.Mp3File",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Album = c.String(maxLength: 255),
                        Artist = c.String(maxLength: 255),
                        Year = c.Int(nullable: false),
                        Genre = c.String(maxLength: 255),
                        Duration = c.Time(nullable: false, precision: 7),
                        Bitrate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mp3FileLocation", "Mp3File_Id", "dbo.Mp3File");
            DropIndex("dbo.Mp3FileLocation", new[] { "Mp3File_Id" });
            DropTable("dbo.Mp3File");
            DropTable("dbo.Mp3FileLocation");
        }
    }
}

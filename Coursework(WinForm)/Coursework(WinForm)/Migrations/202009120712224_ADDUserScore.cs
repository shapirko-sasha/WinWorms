namespace Coursework_WinForm_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDUserScore : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblUserRezalts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserScore = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblUserRezalts", "UserID", "dbo.tblUsers");
            DropIndex("dbo.tblUserRezalts", new[] { "UserID" });
            DropTable("dbo.tblUserRezalts");
        }
    }
}

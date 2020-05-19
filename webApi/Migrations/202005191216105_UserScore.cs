namespace webApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserScore : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserScores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Score = c.Int(nullable: false),
                        Username = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserScores");
        }
    }
}

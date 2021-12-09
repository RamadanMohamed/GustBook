namespace Guestbook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gustbook2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MailModels",
                c => new
                    {
                        smsid = c.Int(nullable: false, identity: true),
                        From = c.String(),
                        To = c.String(),
                        Subject = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.smsid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MailModels");
        }
    }
}

namespace Guestbook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class book1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddSms",
                c => new
                    {
                        IdMs = c.Int(nullable: false, identity: true),
                        ContentMs = c.String(),
                    })
                .PrimaryKey(t => t.IdMs);
            
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        idUser = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.idUser);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registers");
            DropTable("dbo.AddSms");
        }
    }
}

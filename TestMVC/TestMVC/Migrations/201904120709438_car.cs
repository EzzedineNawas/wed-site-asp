namespace TestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class car : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cars",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        work = c.String(nullable: false),
                        phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.cars");
        }
    }
}

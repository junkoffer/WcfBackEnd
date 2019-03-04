namespace WcfBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServiceCase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceCases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CaseNr = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Source = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServiceCaseItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        TennantID = c.String(),
                        ServiceCase_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ServiceCases", t => t.ServiceCase_Id, cascadeDelete: true)
                .Index(t => t.ServiceCase_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceCaseItems", "ServiceCase_Id", "dbo.ServiceCases");
            DropIndex("dbo.ServiceCaseItems", new[] { "ServiceCase_Id" });
            DropTable("dbo.ServiceCaseItems");
            DropTable("dbo.ServiceCases");
        }
    }
}

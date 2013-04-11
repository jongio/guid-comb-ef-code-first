namespace GuidComb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Comb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Items");
        }
    }
}

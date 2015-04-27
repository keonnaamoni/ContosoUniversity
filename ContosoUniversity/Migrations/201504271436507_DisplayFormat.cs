namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DisplayFormat : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Student", "EmailAdress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "EmailAdress", c => c.String());
        }
    }
}

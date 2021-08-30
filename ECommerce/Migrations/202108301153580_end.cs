namespace ECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class end : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "IdCommercial");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "IdCommercial", c => c.Int());
        }
    }
}

namespace DALayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class coloumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "RegistrationStatus", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "RegistrationStatus");
        }
    }
}

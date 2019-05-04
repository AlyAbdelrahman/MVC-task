namespace MyWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditEmp2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "Gender", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "Gender");
        }
    }
}

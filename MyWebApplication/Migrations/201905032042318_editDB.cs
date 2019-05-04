namespace MyWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editDB : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Departmentt", newName: "Department");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Department", newName: "Departmentt");
        }
    }
}

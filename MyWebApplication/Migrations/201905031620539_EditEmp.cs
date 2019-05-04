namespace MyWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditEmp : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employee", "fk_DepartmentId", "dbo.Departmentt");
            DropIndex("dbo.Employee", new[] { "fk_DepartmentId" });
            AlterColumn("dbo.Employee", "fk_DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employee", "fk_DepartmentId");
            AddForeignKey("dbo.Employee", "fk_DepartmentId", "dbo.Departmentt", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "fk_DepartmentId", "dbo.Departmentt");
            DropIndex("dbo.Employee", new[] { "fk_DepartmentId" });
            AlterColumn("dbo.Employee", "fk_DepartmentId", c => c.Int());
            CreateIndex("dbo.Employee", "fk_DepartmentId");
            AddForeignKey("dbo.Employee", "fk_DepartmentId", "dbo.Departmentt", "id");
        }
    }
}

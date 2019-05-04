namespace MyWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmentEmpRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "fk_DepartmentId", c => c.Int());
            CreateIndex("dbo.Employee", "fk_DepartmentId");
            AddForeignKey("dbo.Employee", "fk_DepartmentId", "dbo.Departmentt", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "fk_DepartmentId", "dbo.Departmentt");
            DropIndex("dbo.Employee", new[] { "fk_DepartmentId" });
            DropColumn("dbo.Employee", "fk_DepartmentId");
        }
    }
}

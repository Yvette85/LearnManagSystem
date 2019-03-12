namespace LearnManagSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kay : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AllStudentsViews",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Email = c.String(),
                        CourseName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AllTeachersViews",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AllTeachersViews");
            DropTable("dbo.AllStudentsViews");
        }
    }
}

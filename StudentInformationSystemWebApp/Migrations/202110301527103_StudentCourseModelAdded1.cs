namespace StudentInformationSystemWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentCourseModelAdded1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        SemesterCode = c.String(nullable: false),
                        EntryDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentCourses");
        }
    }
}

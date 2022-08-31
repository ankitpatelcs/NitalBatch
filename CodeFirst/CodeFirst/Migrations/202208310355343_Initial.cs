namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblemployees",
                c => new
                    {
                        emp_id = c.Int(nullable: false, identity: true),
                        f_name = c.String(),
                        salary = c.Int(),
                        mobile = c.String(),
                        email = c.String(),
                        password = c.String(),
                        address = c.String(),
                        dob = c.DateTime(),
                        gender = c.String(),
                        state_id = c.Int(),
                        city_id = c.Int(),
                        hobbies = c.String(),
                        profileimg = c.String(),
                    })
                .PrimaryKey(t => t.emp_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblemployees");
        }
    }
}

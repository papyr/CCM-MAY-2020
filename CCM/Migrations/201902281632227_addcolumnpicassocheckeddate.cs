namespace CCM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumnpicassocheckeddate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "PicassoCheckedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "PicassoCheckedOn");
        }
    }
}

namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_receiver_properties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "ReceiverMail", c => c.String(maxLength: 50));
            DropColumn("dbo.Messages", "RenderMail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "RenderMail", c => c.String(maxLength: 50));
            DropColumn("dbo.Messages", "ReceiverMail");
        }
    }
}

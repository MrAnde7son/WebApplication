namespace Exercise2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Image", c => c.String());
            AlterColumn("dbo.Posts", "Video", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Video", c => c.Binary());
            AlterColumn("dbo.Posts", "Image", c => c.Binary());
        }
    }
}

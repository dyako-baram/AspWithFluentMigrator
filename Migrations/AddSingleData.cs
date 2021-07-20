using FluentMigrator;

namespace AspWithDbup.Migrations
{
    [Migration(3)] 
    public class AddSingleData : Migration
    {
        public override void Down()
        {
            Delete.FromTable("PeopleTbl").Row(new {Id=1});
        }

        public override void Up()
        {
            Insert.IntoTable("PeopleTbl").Row(new {Name="dyako",Email="dyako.baram@gmail.com"});
        }
    }
}
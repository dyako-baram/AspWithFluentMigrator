using FluentMigrator;

namespace AspWithDbup.Scripts
{
    [Migration(2)]
    public class SeedTable : Migration
    {
        public override void Up()
        {
            Execute.Sql(@"INSERT INTO PeopleTbl (Name,Email) VALUES ('Larissa','Nulla.eu.neque@egestas.ca'),('Josephine','pede.sagittis@egestasblanditNam.co.uk'),('Chantale','Nunc.laoreet.lectus@ametlorem.org');");
        }

        public override void Down()
        {
            Execute.Sql(@"TRUNCATE TABLE PeopleTbl;");
        }
    }
}
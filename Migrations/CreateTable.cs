using FluentMigrator;

namespace AspWithDbup.Scripts
{
    [Migration(1)]
    public class CreateTable : Migration
    {
        public override void Up()
        {
            Execute.Sql(@"CREATE TABLE `PeopleTbl` (
                            `Id` INT(12) NOT NULL AUTO_INCREMENT,
                            `Name` VARCHAR(255) CHARACTER SET utf8 COLLATE utf8_general_ci,
                            `Email` VARCHAR(255) CHARACTER SET utf8 COLLATE utf8_general_ci,
                            PRIMARY KEY (`Id`)
                        );"
                        );
        }

        public override void Down()
        {
            Execute.Sql(@"DROP TABLE `PeopleTbl`;");
        }
    }
}
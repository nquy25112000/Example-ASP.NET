using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample1.Migrations
{
    public partial class AddTablePermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("" +
                "Create table Permission" +
                "(id int Primary key Identity(1,1), " +
                "name varchar(255) null);");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Permission");
        }
    }
}

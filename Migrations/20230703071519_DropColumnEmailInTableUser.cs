using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample1.Migrations
{
    public partial class DropColumnEmailInTableUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            {
                migrationBuilder.DropColumn(
                    name: "email",
                    table: "User");
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            {
                migrationBuilder.AddColumn<string>(
                    name: "email",
                    table: "User",
                    nullable: true);
            }
        }
    }
}

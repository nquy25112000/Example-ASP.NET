using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample1.Migrations
{
    public partial class AddTableBookRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookroom",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roomId = table.Column<int>(type: "int", nullable: false),
                    hotelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookroom", x => x.id);
                    table.ForeignKey(
                        name: "FK_bookroom_hotel_hotelId",
                        column: x => x.hotelId,
                        principalTable: "hotel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_bookroom_room_roomId",
                        column: x => x.roomId,
                        principalTable: "room",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookroom_hotelId",
                table: "bookroom",
                column: "hotelId");

            migrationBuilder.CreateIndex(
                name: "IX_bookroom_roomId",
                table: "bookroom",
                column: "roomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookroom");
        }
    }
}

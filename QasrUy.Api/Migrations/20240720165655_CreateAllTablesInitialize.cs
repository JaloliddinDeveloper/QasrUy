using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QasrUy.Api.Migrations
{
    /// <inheritdoc />
    public partial class CreateAllTablesInitialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectedRoom = table.Column<int>(type: "int", nullable: false),
                    HomeSquare = table.Column<double>(type: "float", nullable: false),
                    HomeFloor = table.Column<int>(type: "int", nullable: false),
                    HomeAllFloor = table.Column<int>(type: "int", nullable: false),
                    SelectedAmenities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomePrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeRegion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeLocationAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeLocationLatLng = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pictures_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_HouseId",
                table: "Pictures",
                column: "HouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "Houses");
        }
    }
}

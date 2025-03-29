using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QasrUy.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddSomeProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HomeAddress",
                table: "Houses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "HomeAllFloor",
                table: "Houses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HomeDistrict",
                table: "Houses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "HomeFloor",
                table: "Houses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HomeLocationAddress",
                table: "Houses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "HomeLocationLatLng",
                table: "Houses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "HomePrice",
                table: "Houses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "HomeRegion",
                table: "Houses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "HomeSituation",
                table: "Houses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "HomeSquare",
                table: "Houses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HomeType",
                table: "Houses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "SelectedAmenities",
                table: "Houses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "SelectedRoom",
                table: "Houses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Houses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeAddress",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "HomeAllFloor",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "HomeDistrict",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "HomeFloor",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "HomeLocationAddress",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "HomeLocationLatLng",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "HomePrice",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "HomeRegion",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "HomeSituation",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "HomeSquare",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "HomeType",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "SelectedAmenities",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "SelectedRoom",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Houses");
        }
    }
}

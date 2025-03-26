using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QasrUy.Api.Migrations
{
    /// <inheritdoc />
    public partial class One : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Houses_HouseId",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_HouseId",
                table: "Pictures");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Pictures",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<Guid>(
                name: "HouseId1",
                table: "Pictures",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Houses",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_HouseId1",
                table: "Pictures",
                column: "HouseId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Houses_HouseId1",
                table: "Pictures",
                column: "HouseId1",
                principalTable: "Houses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Houses_HouseId1",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_HouseId1",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "HouseId1",
                table: "Pictures");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Pictures",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Houses",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_HouseId",
                table: "Pictures",
                column: "HouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Houses_HouseId",
                table: "Pictures",
                column: "HouseId",
                principalTable: "Houses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

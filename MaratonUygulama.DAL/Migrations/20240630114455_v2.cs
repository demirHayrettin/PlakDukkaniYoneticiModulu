using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaratonUygulama.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albümler_Sanatci_SanatciID",
                table: "Albümler");

            migrationBuilder.DropTable(
                name: "Sanatci");

            migrationBuilder.DropIndex(
                name: "IX_Albümler_SanatciID",
                table: "Albümler");

            migrationBuilder.DropColumn(
                name: "SanatciID",
                table: "Albümler");

            migrationBuilder.AddColumn<string>(
                name: "SifreKontrol",
                table: "Yöneticiler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sanatci",
                table: "Albümler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SifreKontrol",
                table: "Yöneticiler");

            migrationBuilder.DropColumn(
                name: "Sanatci",
                table: "Albümler");

            migrationBuilder.AddColumn<int>(
                name: "SanatciID",
                table: "Albümler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sanatci",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbumID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanatci", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albümler_SanatciID",
                table: "Albümler",
                column: "SanatciID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Albümler_Sanatci_SanatciID",
                table: "Albümler",
                column: "SanatciID",
                principalTable: "Sanatci",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

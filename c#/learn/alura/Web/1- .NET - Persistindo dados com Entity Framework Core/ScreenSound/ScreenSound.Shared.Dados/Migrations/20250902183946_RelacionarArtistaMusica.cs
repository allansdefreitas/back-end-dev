using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class RelacionarArtistaMusica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "artistId",
                table: "Musicas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Musicas_artistId",
                table: "Musicas",
                column: "artistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musicas_Artistas_artistId",
                table: "Musicas",
                column: "artistId",
                principalTable: "Artistas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicas_Artistas_artistId",
                table: "Musicas");

            migrationBuilder.DropIndex(
                name: "IX_Musicas_artistId",
                table: "Musicas");

            migrationBuilder.DropColumn(
                name: "artistId",
                table: "Musicas");
        }
    }
}

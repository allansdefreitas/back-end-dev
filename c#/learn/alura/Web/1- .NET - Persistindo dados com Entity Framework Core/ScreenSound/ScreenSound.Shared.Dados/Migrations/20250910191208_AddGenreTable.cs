using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class AddGenreTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicas_Artistas_artistId",
                table: "Musicas");

            migrationBuilder.RenameColumn(
                name: "artistId",
                table: "Musicas",
                newName: "ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Musicas_artistId",
                table: "Musicas",
                newName: "IX_Musicas_ArtistId");

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Musicas_Artistas_ArtistId",
                table: "Musicas",
                column: "ArtistId",
                principalTable: "Artistas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicas_Artistas_ArtistId",
                table: "Musicas");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Musicas",
                newName: "artistId");

            migrationBuilder.RenameIndex(
                name: "IX_Musicas_ArtistId",
                table: "Musicas",
                newName: "IX_Musicas_artistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musicas_Artistas_artistId",
                table: "Musicas",
                column: "artistId",
                principalTable: "Artistas",
                principalColumn: "Id");
        }
    }
}

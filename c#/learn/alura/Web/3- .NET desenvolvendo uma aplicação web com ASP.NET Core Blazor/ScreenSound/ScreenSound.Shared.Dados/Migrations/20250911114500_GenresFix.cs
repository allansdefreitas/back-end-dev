using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class GenresFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreSong_Genres_GendersId",
                table: "GenreSong");

            migrationBuilder.RenameColumn(
                name: "GendersId",
                table: "GenreSong",
                newName: "GenresId");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreSong_Genres_GenresId",
                table: "GenreSong",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreSong_Genres_GenresId",
                table: "GenreSong");

            migrationBuilder.RenameColumn(
                name: "GenresId",
                table: "GenreSong",
                newName: "GendersId");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreSong_Genres_GendersId",
                table: "GenreSong",
                column: "GendersId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

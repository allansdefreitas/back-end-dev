using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class RelationSongGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GenreSong",
                columns: table => new
                {
                    GendersId = table.Column<int>(type: "int", nullable: false),
                    SongsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreSong", x => new { x.GendersId, x.SongsId });
                    table.ForeignKey(
                        name: "FK_GenreSong_Genres_GendersId",
                        column: x => x.GendersId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreSong_Musicas_SongsId",
                        column: x => x.SongsId,
                        principalTable: "Musicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenreSong_SongsId",
                table: "GenreSong",
                column: "SongsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenreSong");
        }
    }
}

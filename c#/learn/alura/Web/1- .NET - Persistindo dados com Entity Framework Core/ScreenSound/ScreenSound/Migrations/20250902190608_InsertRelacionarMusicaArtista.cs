using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class InsertRelacionarMusicaArtista : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Deus Muda Situações → Victorino Silva
            migrationBuilder.Sql("UPDATE Musicas SET ArtistId = 14 WHERE Id = 9");

            // Cem Ovelhas → Ozéias de Paula
            migrationBuilder.Sql("UPDATE Musicas SET ArtistId = 19 WHERE Id = 10");

            migrationBuilder.Sql("DELETE FROM Musicas WHERE Id = 11");

            // Eu Não Mudo → Raquel Silva
            migrationBuilder.Sql("UPDATE Musicas SET ArtistId = 16 WHERE Id = 12");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Musicas SET ArtistId = NULL");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                "Musicas",
                new string[] { "Nome", "ReleaseYear" },
                new object[] { "Deus Muda Situações", 2000 }
            );

            migrationBuilder.InsertData(
                "Musicas",
                new string[] { "Nome", "ReleaseYear" },
                new object[] { "Cem Ovelhas", 1973 }
            );

            migrationBuilder.InsertData(
                "Musicas",
                new string[] { "Nome", "ReleaseYear" },
                new object[] { "Além do Rio Azul", 1988 }
            );

            migrationBuilder.InsertData(
                "Musicas",
                new string[] { "Nome", "ReleaseYear" },
                new object[] { "Eu Não Mudo", 1998 }
            );
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("DELETE FROM Musicas");

        }
    }
}

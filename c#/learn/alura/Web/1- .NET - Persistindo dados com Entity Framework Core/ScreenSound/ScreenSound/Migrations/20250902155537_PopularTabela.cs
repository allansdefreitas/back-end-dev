using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                "Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] {
            "Victorino Silva",
            "Cantor de música evangélica; hinos: 'Senhor, Tu És Santo', 'Rude Cruz'",
            "https://i1.sndcdn.com/artworks-796767c7-d6f7-4e38-a03b-f0ce2d82c6bc-0-t240x240.jpg"
                }
            );

            migrationBuilder.InsertData(
                "Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] {
            "Jacira",
            "Cantora clássica de música evangélica; hinos: 'Basta Que Me Toque Senhor', 'A Porta da Graça', 'O Grande Dia'",
            "https://upload.wikimedia.org/wikipedia/commons/0/0a/Jacira.jpg"
                }
            );

            migrationBuilder.InsertData(
                "Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] {
            "Raquel Silva",
            "Cantora tradicional de louvores; hinos: 'Tristezas e Alegrias', 'Eu Não Mudo', 'Só de Joelho'",
            "https://upload.wikimedia.org/wikipedia/commons/1/15/Raquel_Silva.jpg"
                }
            );

            migrationBuilder.InsertData(
                "Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] {
            "Débora Ivanov",
            "Cantora gospel clássica; hinos: 'Estamos Diante do Trono', 'Sou Jesus', 'Grande é Jeová'",
            "https://upload.wikimedia.org/wikipedia/commons/2/24/Debora_Ivanov.jpg"
                }
            );

            migrationBuilder.InsertData(
                "Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] {
            "Eyshila",
            "Cantora evangélica tradicional; hinos: 'Sonda-me, Usa-me', 'Venceu', 'Grande é o Nosso Deus'",
            "https://upload.wikimedia.org/wikipedia/commons/3/36/Eyshila.jpg"
                }
            );
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}

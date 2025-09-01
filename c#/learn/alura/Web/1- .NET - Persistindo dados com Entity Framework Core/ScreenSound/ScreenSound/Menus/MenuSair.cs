using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(ArtistDAL artistDAL)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}

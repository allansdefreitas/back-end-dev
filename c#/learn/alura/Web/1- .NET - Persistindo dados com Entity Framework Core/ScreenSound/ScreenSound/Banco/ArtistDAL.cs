using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
namespace ScreenSound.Banco;

internal class ArtistDAL: DAL<Artist>
{
    //It uses the attribute of the base class
    public ArtistDAL(ScreenSoundContext context) : base(context) { }

}

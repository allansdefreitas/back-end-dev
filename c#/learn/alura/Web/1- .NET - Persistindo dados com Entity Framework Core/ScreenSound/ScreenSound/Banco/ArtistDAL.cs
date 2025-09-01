using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
namespace ScreenSound.Banco;

internal class ArtistDAL: DAL<Artist>
{
    private readonly ScreenSoundContext context;

    public ArtistDAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public override IEnumerable<Artist> ListAll()
    {
        return context.Artists.ToList();
    }

    public override void Add(Artist artist)
    {
        context.Artists.Add(artist);
        context.SaveChanges();
    }

    public override void Update(Artist artist)
    {
        context.Artists.Update(artist);
        context.SaveChanges();
    }

    public override void Delete(Artist artist)
    {
        context.Artists.Remove(artist);
        context.SaveChanges();
    }

    public override Artist Get(int id)
    {
        return context.Artists.Find(id);
    }

    public override Artist? GetByName(string name)
    {
        return context.Artists.FirstOrDefault(a => a.Name.Equals(name));
    }

    public void PrintAll()
    {
        var artists = ListAll();
        foreach (var artist in artists)
        {
            Console.WriteLine(artist);
            Console.WriteLine("===================================");
        }
    }
}

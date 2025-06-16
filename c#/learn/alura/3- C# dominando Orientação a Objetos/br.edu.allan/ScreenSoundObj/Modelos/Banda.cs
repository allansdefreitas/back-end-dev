using ScreenSoundObj.Modelos;

namespace ScreenSoundObj.Modelos;

internal class Banda : IAvaliavel
{
    private List<Album> albuns;
    //public IEnumerable<Album> Albuns => albuns;
    private List<Avaliacao> notas;

    public Banda(string nome)
    {
        Nome = nome;
        notas = new List<Avaliacao>();
        albuns = new List<Album>();
    }

    public string Nome { get; }

    //public double Media => notas.Average(a => a.Nota);
    public double Media
    {
        get
        {
            if (notas.Count == 0)
                return 0;
            else
                return notas.Average(a => a.Nota);
        }

    }

    public List<Album> Albuns => albuns;

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao avaliacao)
    {
        notas.Add(avaliacao);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}
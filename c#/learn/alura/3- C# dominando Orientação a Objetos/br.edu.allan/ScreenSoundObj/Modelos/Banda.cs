namespace Edu.Allan.ScreenSoundObj.Modelos;

class Banda
{
    private List<Album> albuns;
    private List<int> notas;

    public Banda(string nome)
    {
        Nome = nome;
        notas = new List<int>();
        albuns = new List<Album>();
    }

    public string Nome { get; }
    public double Media => notas.Average();
    public List<Album> Albuns => albuns;

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void AdicionarNota(int nota)
    {
        notas.Add(nota);
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
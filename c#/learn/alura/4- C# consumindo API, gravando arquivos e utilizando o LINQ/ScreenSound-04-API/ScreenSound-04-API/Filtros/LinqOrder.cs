using ScreenSound_04_API.Modelos;

namespace ScreenSound_04_API.Filtros;

internal class LinqOrder
{

    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {

        var artistasOrdenados = musicas.OrderBy(musica => 
        musica.Artista)
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();

        Console.WriteLine("Lista ordenada de Artistas:");
        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }

    }
}

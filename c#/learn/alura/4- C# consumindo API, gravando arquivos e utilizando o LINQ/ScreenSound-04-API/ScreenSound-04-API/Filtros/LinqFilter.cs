using ScreenSound_04_API.Filtros;
using ScreenSound_04_API.Modelos;


namespace ScreenSound_04_API.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosGenerosMusicais(List<Musica> musicas)
    {

        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

        Console.WriteLine("Exibindo todos os gêneros musicais");

        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string generoMusical)
    {

        var artistasPorGeneroMusical = musicas
            .Where(musica => musica.Genero!.Contains(generoMusical))
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();

        Console.WriteLine($"Exibindo todos os artistas do gênero {generoMusical}");

        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }

    }

}

using ScreenSound_04_API.Filtros;
using ScreenSound_04_API.Modelos;


namespace ScreenSound_04_API.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosGenerosMusicais(List<Musica> musicas)
    {

        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

        Console.WriteLine(todosOsGenerosMusicais);

        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }

    }

}

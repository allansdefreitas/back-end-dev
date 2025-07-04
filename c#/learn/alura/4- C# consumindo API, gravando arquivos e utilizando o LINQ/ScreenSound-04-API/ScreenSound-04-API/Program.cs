﻿
using ScreenSound_04_API.Modelos;
using ScreenSound_04_API.Filtros;
using System.Text.Json;

internal class Program
{

    private const string URL_API_GET = "https://raw.githubusercontent.com/guilhermeonrails/api-csharp-songs/refs/heads/main/songs.json";
    private static async Task Main(string[] args)

    {
        using (HttpClient client = new HttpClient())
        {  
            try
            {
                string resposta = await client.GetStringAsync(URL_API_GET);
                //Console.WriteLine(resposta);

                var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

                //musicas[0].ExibirDetalhes();

                //LinqFilter.FiltrarTodosGenerosMusicais(musicas);

                //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

                //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");

                //LinqFilter.FiltrarMusicasPorArtista(musicas, "50 Cent");

                //LinqFilter.FiltrarMusicasPorAno(musicas, 2011);

                var playlist = new Playlist("John");

                playlist.Adicionar(musicas[0]);
                playlist.Adicionar(musicas[55]);
                playlist.Adicionar(musicas[44]);
                playlist.Adicionar(musicas[32]);
                playlist.Adicionar(musicas[47]);

                playlist.ExibirMusicas();
                Console.WriteLine();

                var playlistMathew = new Playlist("Mathew");

                playlistMathew.Adicionar(musicas[149]);
                playlistMathew.Adicionar(musicas[155]);
                playlistMathew.Adicionar(musicas[144]);
                playlistMathew.Adicionar(musicas[232]);
                playlistMathew.Adicionar(musicas[247]);

                playlistMathew.ExibirMusicas();

                Console.WriteLine();

                playlistMathew.GerarArquivoJSON();


            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occured: {ex.Message}");
            }
            
        }
    }
}
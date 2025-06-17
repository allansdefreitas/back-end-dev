
using ScreenSound_04_API.Modelos;
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

                musicas[0].ExibirDetalhes();

                foreach(Musica musica in musicas)
                {
                    if (musica.Genero.Contains("Electronic"))
                    {
                        musica.ExibirDetalhes();
                        Console.WriteLine("\n\n");
                    }
                }


            }catch(Exception ex)
            {
                Console.WriteLine($"An error occured: {ex.Message}");
            }
            
        }
    }
}
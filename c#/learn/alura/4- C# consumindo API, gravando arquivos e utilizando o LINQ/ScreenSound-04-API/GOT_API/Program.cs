using GOT_API.Modelos;
using System.Text.Json;

internal class Program
{
    private const string URL_API = "https://www.anapioficeandfire.com/api/characters/16";

    private static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            var json = await client.GetStringAsync(URL_API);
            

            var personagem = JsonSerializer.Deserialize<Personagem>(json)!;

            personagem.ExibirDetalhes();

        }
    }
}
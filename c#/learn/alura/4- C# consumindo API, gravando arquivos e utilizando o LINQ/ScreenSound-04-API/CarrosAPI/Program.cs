using CarrosAPI.Modelos;
using System.Text.Json;

internal class Program
{
    private const string URL_API = "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json";
    private static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            string resposta = await client.GetStringAsync(URL_API);
            
            var carros = JsonSerializer.Deserialize<List<Carro>>(resposta);

            foreach(Carro carro in carros)
            {
                carro.Exibir();
                
            }


        }

    }
}
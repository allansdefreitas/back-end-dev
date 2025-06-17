
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
                Console.WriteLine(resposta);
            }catch(Exception ex)
            {
                Console.WriteLine($"An error occured: {ex.Message}");
            }
            
        }
    }
}
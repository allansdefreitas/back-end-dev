internal class Program
{

    private const string URL_API = "https://www.cheapshark.com/api/1.0/deals";
    private static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            string response = await client.GetStringAsync(URL_API);

            Console.WriteLine(response);
        }
    }
}
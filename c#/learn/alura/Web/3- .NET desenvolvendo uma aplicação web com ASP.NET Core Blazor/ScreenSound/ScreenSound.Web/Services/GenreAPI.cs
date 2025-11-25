using ScreenSound.Web.Response;
using System.Net.Http.Json;

namespace ScreenSound.Web.Services;

public class GenreAPI
{

    private readonly HttpClient _httpClient;

    public GenreAPI(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("API");
    }

    public async Task<ICollection<GenreResponse>?> GetGenresAsync()
    {
        return await _httpClient.GetFromJsonAsync<ICollection<GenreResponse>>("genres");
    }



}

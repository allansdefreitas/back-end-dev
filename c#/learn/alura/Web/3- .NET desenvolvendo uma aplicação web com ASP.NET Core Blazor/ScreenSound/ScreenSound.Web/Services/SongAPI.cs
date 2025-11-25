using ScreenSound.Web.Response;
using System.Net.Http.Json;

namespace ScreenSound.Web.Services;

public class SongAPI
{

    private readonly HttpClient _httpClient;

    public SongAPI(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("API");
    }

    public async Task<ICollection<SongResponse>?> GetSongsAsync()
    {
        return await _httpClient.GetFromJsonAsync<ICollection<SongResponse>>("songs");
    }



}

using ScreenSound.Modelos;

namespace ScreenSound.API.Response;

public record SongResponse(int id, string Name, int ArtistId, string ArtistName, int ReleaseYear);

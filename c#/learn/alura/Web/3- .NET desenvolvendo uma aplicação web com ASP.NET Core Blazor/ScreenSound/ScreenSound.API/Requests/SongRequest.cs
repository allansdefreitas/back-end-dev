using ScreenSound.Shared.Modelos.Modelos;

namespace ScreenSound.API.Requests;

public record SongRequest(string Name, int ArtistId, int ReleaseYear, ICollection<GenreRequest> Genres = null);
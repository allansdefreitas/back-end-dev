using ScreenSound.Shared.Modelos.Modelos;

namespace ScreenSound.API.Requests;

public record SongRequest(string name, int artistId, int releaseYear, ICollection<GenreRequest> genres = null);
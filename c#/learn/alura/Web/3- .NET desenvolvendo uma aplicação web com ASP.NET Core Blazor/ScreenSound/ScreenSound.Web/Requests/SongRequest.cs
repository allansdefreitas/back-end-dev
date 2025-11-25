namespace ScreenSound.Web.Requests;

public record SongRequest(string Name, int ArtistId, int ReleaseYear, ICollection<GenreRequest> Genres = null);
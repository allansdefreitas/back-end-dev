using Microsoft.AspNetCore.Mvc;
using ScreenSound.Web.Requests;
using ScreenSound.Web.Response;
using ScreenSound.Modelos;
using ScreenSound.Shared.Modelos.Modelos;

namespace ScreenSound.API.Endpoints;

public static class SongsExtensions
{

    // Método de extensão. Aqui, o método extende WebApplication
    public static void AddEndpointsSongs(this WebApplication app)
    {
        app.MapGet("/Songs", ([FromServices] DAL<Song> dal) =>
        {
            var songsResponseList = EntityListToResponseList(dal.ListAll());
            return Results.Ok(songsResponseList);
        });

        app.MapGet("/Songs/{name}", ([FromServices] DAL<Song> dal, string name) =>
        {
            var songsList = dal.ListBy(a => a.Name.ToUpper().Equals(name.ToUpper()));

            if (songsList is null)
            {
                return Results.NotFound();
            }

            var songsResponseList = EntityListToResponseList(songsList);
            return Results.Ok(songsList);
        });

        app.MapGet("/Songs/{id:int}", ([FromServices] DAL<Song> dal, int id) =>
        {
            var song = dal.GetBy(a => a.Id == id);
            if (song is null)
            {
                return Results.NotFound();
            }
            else
            {
                var songResponse = EntityToResponse(song);
                return Results.Ok(songResponse);
            }
        });

        app.MapPost("/Songs", ([FromServices] DAL<Song> dal,
            [FromServices] DAL <Genre> dalGenre,
            [FromBody] SongRequest songRequest) =>
        {

            var song = new Song()
            {

                Name = songRequest.Name,
                ReleaseYear = songRequest.ReleaseYear,
                ArtistId = songRequest.ArtistId,
                Genres = songRequest.Genres is not null ? 
                    GenreRequestConverter(songRequest.Genres, dalGenre) :
                    new List<Genre>(),
                Artist = new Artist()
                {
                    Bio = "",
                }
            };

            dal.Add(song);
            var songResponse = EntityToResponse(song);
            return Results.Ok(songResponse);

        });

        app.MapDelete("/Songs/{id}", ([FromServices] DAL<Song> dal, int id) =>
        {
            var song = dal.GetBy(a => a.Id == id);
            if (song is null)
            {
                return Results.NotFound();
            }
            else
            {
                dal.Delete(song);
                return Results.NoContent();
            }

        });

        app.MapPut("/Songs", ([FromServices] DAL<Song> dal, [FromBody] SongRequestEdit songRequestEdit) =>
        {

            var song = new Song(songRequestEdit.Name, songRequestEdit.ReleaseYear)
            {
                Id = songRequestEdit.Id
            };

            var songFound = dal.GetBy(a => a.Id == song.Id);
            if (songFound is null)
            {
                return Results.NotFound();
            }
            else
            {
                //songFound.Id = song.Id;
                songFound.Name = song.Name;
                songFound.ReleaseYear = song.ReleaseYear;
                songFound.Artist = song.Artist;

                dal.Update(songFound);

                var songFoundResponse = EntityToResponse(songFound);
                return Results.Ok(songFoundResponse);
            }

        });


    }

    //O existente vai persistir com id, o que gera update e o novo vai gerar insert, já que vem sem ID.
    //Essa solução proposta pelo professor, utilizando código em vez de mecanismos apropriados do EF Core, não está boa!
    private static ICollection<Genre> GenreRequestConverter(ICollection<GenreRequest> genresRequest, DAL<Genre> dalGenre)
    {
        var genresList = new List<Genre>();
        foreach (var genre in genresRequest)
        {
            var entity = RequestToEntity(genre);

            var entityFound = dalGenre.GetBy(g => g.Name.ToUpper().Equals( entity.Name.ToUpper() ) );
            if (entityFound is not null)
            {
                genresList.Add(entityFound);
            }
            else
            {
                genresList.Add(entity);
            }
        }

        return genresList;
    }

    private static Genre RequestToEntity(GenreRequest genreRequest)
    {
        Genre genre = new Genre(genreRequest.Name, genreRequest.Description);

        return genre;
    }

    private static ICollection<SongResponse> EntityListToResponseList(IEnumerable<Song> songsList)
    {
        return songsList.Select(a => EntityToResponse(a)).ToList();
    }

    private static SongResponse EntityToResponse(Song song)
    {

        var songResponse = new SongResponse(song.Id, song.Name!, song.Artist!.Id, song.Artist.Name);
        return songResponse;
    }

}

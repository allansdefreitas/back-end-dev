using Microsoft.AspNetCore.Mvc;
using ScreenSound.API.Requests;
using ScreenSound.API.Response;
using ScreenSound.Modelos;

namespace ScreenSound.API.Endpoints;

public static class SongsExtensions
{

    // Método de extensão. Aqui, o método extende WebApplication
    public static void AddEndpointsSongs(this WebApplication app)
    {
        app.MapGet("/Songs", ([FromServices] DAL<Song> dal) =>
        {
            //var songsResponseList = EntityListToResponseList(dal.ListAll());
            return Results.Ok(dal.ListAll());
        });

        app.MapGet("/Songs/{name}", ([FromServices] DAL<Song> dal, string name) =>
        {
            var song = dal.ListBy(a => a.Name.ToUpper().Equals(name.ToUpper()));

            if (song is null)
            {
                return Results.NotFound();
            }

            Console.WriteLine("song: " + song);
            return Results.Ok(song);
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
                Console.WriteLine("song: " + song);
                return Results.Ok(song);
            }
        });

        app.MapPost("/Songs", ([FromServices] DAL<Song> dal, [FromBody] SongRequest songRequest) =>
        {

            var song = new Song(songRequest.name, songRequest.releaseYear);
            dal.Add(song);

            return Results.Ok(song);

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

            var song = new Song(songRequestEdit.name, songRequestEdit.releaseYear)
            {
                Id = songRequestEdit.id
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
                return Results.Ok(songFound);
            }

        });


    }
    private static ICollection<SongResponse> EntityListToResponseList(IEnumerable<Song> songsList)
    {
        return songsList.Select(a => EntityToResponse(a)).ToList();
    }

    private static SongResponse EntityToResponse(Song song)
    {
        return new SongResponse(song.Id, song.Name!, song.Artist!.Id, song.Artist.Name, song.ReleaseYear);
    }

}

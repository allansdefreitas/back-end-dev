using Microsoft.AspNetCore.Mvc;
using ScreenSound.API.Requests;
using ScreenSound.API.Response;
using ScreenSound.Modelos;

namespace ScreenSound.API.Endpoints;

public static class ArtistsExtensions
{

    public static void AddEndpointsArtists(this WebApplication app)
    {
        app.MapGet("/Artists", ([FromServices] DAL<Artist> dal) =>
        {
            return Results.Ok(dal.ListAll());
        });

        app.MapGet("/Artists/{name}", ([FromServices] DAL<Artist> dal, string name) =>
        {
            var artist = dal.ListBy(a => a.Name.ToUpper().Equals(name.ToUpper()));

            if (artist is null)
            {
                return Results.NotFound();
            }

            Console.WriteLine("artist: " + artist);
            return Results.Ok(artist);
        });

        app.MapGet("/Artists/{id:int}", ([FromServices] DAL<Artist> dal, int id) =>
        {
            var artist = dal.GetBy(a => a.Id == id);
            if (artist is null)
            {
                return Results.NotFound();
            }
            else
            {
                Console.WriteLine("artist: " + artist);
                return Results.Ok(artist);
            }
        });

        app.MapPost("/Artists", ([FromServices] DAL<Artist> dal, [FromBody] ArtistRequest artistRequest) =>
        {
            var artist = new Artist(artistRequest.name, artistRequest.bio);

            dal.Add(artist);
            return Results.Ok();

        });

        app.MapDelete("/Artists/{id}", ([FromServices] DAL<Artist> dal, int id) =>
        {
            var artist = dal.GetBy(a => a.Id == id);
            if (artist is null)
            {
                return Results.NotFound();
            }
            else
            {
                dal.Delete(artist);
                return Results.NoContent();
            }
        });

        
        app.MapPut("/Artists", ([FromServices] DAL<Artist> dal, [FromBody] ArtistRequestEdit artistRequestEdit) =>
        {
            var artist = new Artist(artistRequestEdit.name, artistRequestEdit.bio)
            {
                Id = artistRequestEdit.id
            };

            var artistFound = dal.GetBy(a => a.Id == artist.Id);
            if (artistFound is null)
            {
                return Results.NotFound();
            }
            else
            {
                artistFound.Id = artist.Id;
                artistFound.Name = artist.Name;
                artistFound.ProfilePicture = artist.ProfilePicture;
                artistFound.Bio = artist.Bio;
                artistFound.Songs = artist.Songs;

                dal.Update(artistFound);
                return Results.Ok(artistFound);
            }
        });
    }
    private static ICollection<ArtistResponse> EntityListToResponseList(IEnumerable<Artist> artistsList)
    {
        return artistsList.Select(a => EntityToResponse(a)).ToList();
    }

    private static ArtistResponse EntityToResponse(Artist artist)
    {
        return new ArtistResponse(artist.Id, artist.Name, artist.Bio, artist.ProfilePicture);
    }
}

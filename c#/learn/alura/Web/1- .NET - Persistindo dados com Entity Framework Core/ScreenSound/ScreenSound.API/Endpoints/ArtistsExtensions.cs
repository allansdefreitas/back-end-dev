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

            var artistResponseList = EntityListToResponseList(dal.ListAll());
            return Results.Ok(artistResponseList);
        });

        app.MapGet("/Artists/{name}", ([FromServices] DAL<Artist> dal, string name) =>
        {
            var artistList = dal.ListBy(a => a.Name.ToUpper().Equals(name.ToUpper()));

            if (artistList is null)
            {
                return Results.NotFound();
            }

            var artistResponseList = EntityListToResponseList(artistList);
            return Results.Ok(artistResponseList);
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
                var artistResponse = EntityToResponse(artist);
                return Results.Ok(artistResponse);
            }
        });

        app.MapPost("/Artists", ([FromServices] DAL<Artist> dal, [FromBody] ArtistRequest artistRequest) =>
        {
            var artist = new Artist(artistRequest.name, artistRequest.bio);

            dal.Add(artist);

            var artistResponse = EntityToResponse(artist);
            return Results.Ok(artistResponse);

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
                Id = artistRequestEdit.id,
                ProfilePicture = artistRequestEdit.profilePicture,
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

                var artistFoundResponse = EntityToResponse(artistFound);
                return Results.Ok(artistFoundResponse);
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

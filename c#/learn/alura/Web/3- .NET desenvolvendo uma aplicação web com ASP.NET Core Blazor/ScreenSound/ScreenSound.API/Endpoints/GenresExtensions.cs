using Microsoft.AspNetCore.Mvc;
using ScreenSound.API.Requests;
using ScreenSound.API.Response;
using ScreenSound.Modelos;
using ScreenSound.Shared.Modelos.Modelos;

namespace ScreenSound.API.Endpoints;

public static class GenresExtensions
{

    // Método de extensão. Aqui, o método extende WebApplication
    public static void AddEndpointsGenres(this WebApplication app)
    {
        app.MapGet("/Genres", ([FromServices] DAL<Genre> dal) =>
        {
            var genresResponseList = EntityListToResponseList(dal.ListAll());
            return Results.Ok(genresResponseList);
        });

        app.MapGet("/Genres/{name}", ([FromServices] DAL<Genre> dal, string name) =>
        {
            var genres = dal.ListBy(a => a.Name.ToUpper().Equals(name.ToUpper()));

            if (genres is null)
            {
                return Results.NotFound();
            }

            var genresResponseList = EntityListToResponseList(genres);
            return Results.Ok(genresResponseList);
        });

        app.MapGet("/Genres/{id:int}", ([FromServices] DAL<Genre> dal, int id) =>
        {
            var genre = dal.GetBy(a => a.Id == id);
            if (genre is null)
            {
                return Results.NotFound();
            }
            else
            {
                var genreResponse = EntityToResponse(genre);
                return Results.Ok(genreResponse);
            }
        });

        app.MapPost("/Genres", ([FromServices] DAL<Genre> dal, [FromBody] GenreRequest genreRequest) =>
        {

            var genre = RequestToEntity(genreRequest);

            dal.Add(genre);

            var genreResponse = EntityToResponse(genre);
            return Results.Ok(genreResponse);

        });

        app.MapDelete("/Genres/{id}", ([FromServices] DAL<Genre> dal, int id) =>
        {
            var genre = dal.GetBy(a => a.Id == id);
            if (genre is null)
            {
                return Results.NotFound();
            }
            else
            {
                dal.Delete(genre);
                return Results.NoContent();
            }

        });

        app.MapPut("/Genres", ([FromServices] DAL<Genre> dal, [FromBody] GenreRequestEdit genreRequestEdit) =>
        {

            var genre = new Genre(genreRequestEdit.Name, genreRequestEdit.Description);

            var genreFound = dal.GetBy(a => a.Id == genre.Id);
            if (genreFound is null)
            {
                return Results.NotFound();
            }
            else
            {
                //genreFound.Id = genre.Id;
                genreFound.Name = genre.Name;
                genreFound.Description = genre.Description;

                dal.Update(genreFound);

                var genreFoundResponse = EntityToResponse(genreFound);
                return Results.Ok(genreFoundResponse);
            }

        });


    }


    private static Genre RequestToEntity(GenreRequest genreRequest)
    {
        Genre genre = new Genre(genreRequest.Name, genreRequest.Description);
        return genre;
    }

    private static ICollection<GenreResponse> EntityListToResponseList(IEnumerable<Genre> genresList)
    {
        return genresList.Select(a => EntityToResponse(a)).ToList();
    }

    private static GenreResponse EntityToResponse(Genre genre)
    {
        return new GenreResponse(genre.Id, genre.Name, genre.Description);
    }

}

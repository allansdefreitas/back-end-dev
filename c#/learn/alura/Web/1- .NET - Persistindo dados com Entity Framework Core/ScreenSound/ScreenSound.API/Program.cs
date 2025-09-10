using Microsoft.AspNetCore.Mvc;
using ScreenSound.Banco;
using ScreenSound.Modelos;
using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<ScreenSoundContext>();
        builder.Services.AddTransient<DAL<Artist>>();

        // Evita erro da serialização cíclica de atributo
        builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
        var app = builder.Build();

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

        app.MapPost("/Artists", ([FromServices] DAL<Artist> dal, [FromBody] Artist artist) =>
        {
            dal.Add(artist);

            return Results.Ok(artist);

        });


        app.Run();
    }
}
using Microsoft.AspNetCore.Mvc;
using ScreenSound.API.Endpoints;
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
        builder.Services.AddTransient<DAL<Song>>();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Evita erro da serialização cíclica de atributo
        builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
        var app = builder.Build();

   
        ArtistsExtensions.AddEndpointsArtists(app);
        SongsExtensions.AddEndpointsSongs(app);


        app.UseSwagger();
        app.UseSwaggerUI();

        app.Run();
    }
}
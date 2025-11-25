using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ScreenSound.API.Endpoints;
using ScreenSound.Banco;
using ScreenSound.Modelos;
using ScreenSound.Shared.Modelos.Modelos;
using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<ScreenSoundContext>((options) =>
        {
            options
                .UseSqlServer(builder.Configuration["ConnectionStrings:ScreenSoundDB"])
                .UseLazyLoadingProxies(false);

        });

        builder.Services.AddTransient<DAL<Artist>>();
        builder.Services.AddTransient<DAL<Song>>();
        builder.Services.AddTransient<DAL<Genre>>();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Evita erro da serialização cíclica de atributo
        builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(policy =>
            {
                policy.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader();
            });
        });

        var app = builder.Build();

        app.UseCors();

        ArtistsExtensions.AddEndpointsArtists(app);
        SongsExtensions.AddEndpointsSongs(app);
        GenresExtensions.AddEndpointsGenres(app);

        app.UseSwagger();
        app.UseSwaggerUI();

        app.Run();
    }
}
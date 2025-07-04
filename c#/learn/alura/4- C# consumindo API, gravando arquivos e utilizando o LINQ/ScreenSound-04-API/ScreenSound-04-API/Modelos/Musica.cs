﻿using System.Text.Json.Serialization;

namespace ScreenSound_04_API.Modelos;

internal class Musica
{

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string? AnoString { get; set; }



    public int Ano
    {
        get
        {
            return int.Parse(AnoString!);
        }

    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Duração (segundos): {Duracao /1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
    }

}

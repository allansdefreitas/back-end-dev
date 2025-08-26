using System.Text.Json.Serialization;

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

    [JsonPropertyName("key")]
    private int KeyInt { get; set; }



    public string Key
    {
        get
        {
            switch (KeyInt)
            {
                case 0:
                    return "C";

                case 1:
                    return "C#";

                case 2:
                    return "D";

                case 3:
                    return "D#";

                case 4:
                    return "E";

                case 5:
                    return "F";

                case 6:
                    return "F#";

                case 7:
                    return "G";

                case 8:
                    return "G#";

                case 9:
                    return "A";

                case 10:
                    return "A#";

                case 11:
                    return "B";
                default:
                    return "";
            }
            
        }
    }


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
        Console.WriteLine($"Key: {Key}");
    }

}

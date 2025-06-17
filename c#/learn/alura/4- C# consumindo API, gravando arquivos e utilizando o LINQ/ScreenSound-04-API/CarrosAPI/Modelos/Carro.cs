using System.Text.Json.Serialization;

namespace CarrosAPI.Modelos;

internal class Carro
{

    [JsonPropertyName("marca")]
    public string Marca { get; set; }

    [JsonPropertyName("modelo")]
    public string Modelo { get; set; }

    [JsonPropertyName("ano")]
    public int Ano { get; set; }


    public void Exibir()
    {
        Console.WriteLine($"{Marca} {Modelo} ({Ano})");
    }
}

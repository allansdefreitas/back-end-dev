using System.Text.Json.Serialization;

namespace GOT_API.Modelos;

internal class Personagem
{

    [JsonPropertyName("name")]
    public string Nome { get; set; }

    [JsonPropertyName("gender")]
    public string Sexo { get; set; }

    [JsonPropertyName("born")]
    public string InfosNascimento { get; set; }

    [JsonPropertyName("titles")]
    public List<string>? Titulos { get; set; }


    public Personagem() { 
    
        Titulos = new List<string>();
    }


    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Sexo: {Sexo}");
        Console.WriteLine($"Data e local de nascimento: {InfosNascimento}");
        Console.WriteLine("Títulos: ");
        Titulos.ForEach(t => Console.WriteLine($"\"{t}\""));
            
    }



}

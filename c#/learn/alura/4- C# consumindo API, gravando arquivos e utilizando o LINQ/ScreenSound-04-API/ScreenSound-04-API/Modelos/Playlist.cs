using System.Text.Json;
using System.Text.Json.Serialization;

namespace ScreenSound_04_API.Modelos;

internal class Playlist
{

  
    public string? Nome { get; set; }

    public List<Musica> musicas { get; }


    public Playlist(string nome)
    {
        Nome = nome;
        musicas = new List<Musica> ();
    }

    public void Adicionar(Musica musica)
    {
        musicas.Add (musica);
    }

    public void ExibirMusicas()
    {

        Console.WriteLine($"Músicas favoritas de {Nome}");
        for (int i = 0; i < musicas.Count; i++) 
        { 
            Musica musica = musicas[i];
            Console.WriteLine($"{i+1}. {musica.Nome} ({musica.Artista})");
        }
    }

    public void GerarArquivoJSON()
    {
        // Criando um objeto anônimo
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = musicas
        });
        
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        
        Console.WriteLine($"Arquivo \"{nomeDoArquivo}\" JSON criado com sucesso em {Path.GetFullPath(nomeDoArquivo)}!");
    }

}

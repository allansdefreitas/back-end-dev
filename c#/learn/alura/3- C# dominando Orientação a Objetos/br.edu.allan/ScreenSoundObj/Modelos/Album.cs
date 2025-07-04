﻿namespace ScreenSoundObj.Modelos;

internal class Album : IAvaliavel
{
    private List<Musica> musicas;
    private int _quantidadeTotalObjetos = 0;
    private List<Avaliacao> notas;

    public Album(string nome)
    {
        Nome = nome;
        musicas = new List<Musica>();
        _quantidadeTotalObjetos++;
        notas = new List<Avaliacao>();
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;

    public double Media
    {
        get
        {
            if (notas.Count == 0) {
                return 0;
            }
            else
            {
                return notas.Average(a => a.Nota);
            }
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }
}
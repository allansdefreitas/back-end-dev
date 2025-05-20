namespace Edu.Allan.Filmes;

public class Filme
{

    public string Titulo { get; set; }

    public int AnoLancamento { get; }
    public double Avaliacao { get; set; }
    public int Duracao { get; set; }
    public List<Artista> ListaElenco { get; }


    public Filme(string titulo, int anoLancamento, double avaliacao)
    {
        Titulo = titulo;
        AnoLancamento = anoLancamento;
        Avaliacao = avaliacao;
        ListaElenco = new List<Artista>();
    }

    public void AdicionarArtista(Artista artista)
    {
        ListaElenco.Add(artista);
        artista.AdicionarFilme(this);
    }

    public void ExibirElenco()
    {
        foreach (var artista in ListaElenco)
        {
            Console.WriteLine($"{artista.Nome}");
        }
    }



}

namespace Edu.Allan.Filmes;

public class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> ListaFilmografia { get; }


    public Artista(string nome)
    {
        Nome = nome;
        ListaFilmografia = new List<Filme>();
    }

    public void AdicionarFilme(Filme filme)
    {
        ListaFilmografia.Add(filme);
        // filme.AdicionarArtista(this);
    }

    public void ExibirFilmografia()
    {
        foreach (var filme in ListaFilmografia
            .OrderBy(f => f.Avaliacao)
            .ThenBy(f => f.AnoLancamento))
        {
            Console.WriteLine($"{filme.Titulo} ({filme.AnoLancamento})");
        }
    }
}

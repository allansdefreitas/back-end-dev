public class Podcast
{

    public string Host { get; }
    public string Nome { get; }

    private List<Episodio> episodios;

    public Podcast(string host, string nome)
    {
        episodios = new List<Episodio>();
        Host = host;
        Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        this.episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\n{Nome} - ({Host})\n");

        foreach (var episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"\nTotal de episódios: {episodios.Count}");

    }

}
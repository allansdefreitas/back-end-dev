public class Podcast
{

    private string host;
    private string nome;

    private List<Episodio> episodios;

    public Podcast(string host, string nome)
    {
        host = host;
        nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        this.episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"{nome} ({host})");

        for (int i = 0; i < episodios.Count; i++)
        {
            Episodio ithEpisodio = episodios[i];
            Console.WriteLine(ithEpisodio.Resumo);
        }

        Console.WriteLine($"Total de episódios: {episodios.Count}");

    }

}
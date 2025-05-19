public class Episodio
{

    public string Titulo { get; }
    public int Ordem { get; }
    public int DuracaoEmMinutos { get; }

    public string Resumo => @$"{Ordem}. {Titulo} ({DuracaoEmMinutos} min) - {string.Join(", ", convidados.Select(c => c.Nome))}.";

    private List<Convidado> convidados;

    public Episodio(int ordem, string titulo, int duracaoEmMinutos)
    {
        Ordem = ordem;
        Titulo = titulo;
        DuracaoEmMinutos = duracaoEmMinutos;
        convidados = new List<Convidado>();
    }

    public void AdicionarConvidado(Convidado convidado)
    {
        convidados.Add(convidado);
    }




}
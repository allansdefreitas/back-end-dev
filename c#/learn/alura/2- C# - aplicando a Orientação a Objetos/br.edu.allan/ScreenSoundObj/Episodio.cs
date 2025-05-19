public class Episodio
{

    public string Titulo { get; set; }
    private int ordem;
    public string Resumo
    {
        get =>
            $"{ordem}. {Titulo} ({(float)DuracaoEmSegundos / 60} min) - {convidados}";
    }
    public int DuracaoEmSegundos { get; set; }

    private List<Convidado> convidados;

    public Episodio(string titulo)
    {
        Titulo = titulo;
        convidados = new List<Convidado>();
    }

    public void AdicionarConvidado(Convidado convidado)
    {
        convidados.Add(convidado);
    }




}
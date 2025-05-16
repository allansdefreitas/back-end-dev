public class Cardapio
{
    public List<Prato> Pratos { get; }

    public Cardapio()
    {
        this.Pratos = new List<Prato>();
    }


    public void AdicionarPrato(Prato prato)
    {
        this.Pratos.Add(prato);
    }

    public void ExibirCardapio()
    {
        for (int i = 0; i < this.Pratos.Count; i++)
        {
            Prato ithPrato = Pratos[i];
            Console.WriteLine($"{i + 1}. {ithPrato.Nome}");
        }
    }


}
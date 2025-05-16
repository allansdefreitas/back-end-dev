
public class Restaurante
{

    public string Nome { get; set; }
    public List<Mesa> Mesas { get; }
    public Cardapio Cardapio { get; set; }

    public Restaurante()
    {
        this.Cardapio = new Cardapio();
    }

    public void AdicionarMesa(Mesa mesa)
    {
        this.Mesas.Add(mesa);
    }

}
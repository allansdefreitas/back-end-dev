public class Pedido
{

    public Prato Prato { get; set; }
    public string Observacao { get; set; }
    public Mesa Mesa { get; set; }

    public void ExibirDescricaoPedido()
    {
        Console.WriteLine($"Prato: {Prato.Nome} - Observação: {Observacao} - Mesa: {Mesa.Numero}");
    }

}
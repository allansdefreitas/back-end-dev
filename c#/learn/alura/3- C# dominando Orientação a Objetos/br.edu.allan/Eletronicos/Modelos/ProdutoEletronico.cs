namespace Eletronicos.Modelos;

internal class ProdutoEletronico
{
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public double Preco { get; set; }


    public virtual string ExibirInformacoes()
    {
        return $"Marca: {Marca}\nModelo: {Modelo}\nPreço: {Preco:C}";
    }
}

namespace Eletronicos.Modelos;

internal class Notebook : ProdutoEletronico
{
    public string SistemaOperacional { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}\nSO: {SistemaOperacional}";
    }
}

public class Estoque
{

    public string Nome { get; set; }
    public List<Produto> Produtos = new List<Produto>();


    public void AdicionarProduto(Produto produto)
    {
        this.Produtos.Add(produto);
    }

    public void ExibirProdutos()
    {
        Console.WriteLine($"Produtos do estoque {this.Nome}\n");

        foreach (var produto in Produtos)
        {
            Console.WriteLine(produto.DescricaoProduto);
        }
    }

}
public class Produto
{
    private double preco;
    private int estoque;
    public string Nome { get; set; }
    public string Marca { get; set; }


    public double Preco
    {
        get => preco;
        set
        {
            if (value > 0)
            {
                preco = value;
            }
            else
            {
                Console.WriteLine("O preço não pode ser negativo!");
                preco = 0;
            }
        }
    }

    public int Estoque
    {
        get => estoque;
        set
        {
            if (value > 0)
                estoque = value;
            else
                estoque = 0;

        }
    }

    public string DescricaoProduto => $"{this.Nome} {this.Marca} - R$ {this.Preco}";


}

namespace Eletronicos.Modelos;

internal class PianoDigital : ProdutoEletronico
{
    public int QuantidadeTeclas { get; set; }
    public int QuantidadeTimbres { get; set; }


    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}\nQuantidadeTeclas: {QuantidadeTeclas}" +
            $"\nQuantidade de Timbres: {QuantidadeTimbres}";
    }


}

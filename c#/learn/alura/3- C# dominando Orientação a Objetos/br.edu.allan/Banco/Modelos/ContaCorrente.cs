namespace Banco.Modelos;

internal class ContaCorrente : Conta
{

    private double TaxaManutencao { get; set; }

    public override void Sacar(double valor)
    {
        base.Sacar(valor + TaxaManutencao);
    }

}

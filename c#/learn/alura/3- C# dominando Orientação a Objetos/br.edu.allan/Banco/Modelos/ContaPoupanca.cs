namespace Banco.Modelos;

internal class ContaPoupanca : Conta
{
    private double TaxaRendimento { get; set; }

    public override double CalcularSaldo()
    {
        return base.CalcularSaldo() * (1 + TaxaRendimento);
    }

}

namespace Banco.Modelos;

public class ContaPoupanca : Conta
{

    private double TaxaManutencao { get; set; }

    public override void Sacar(double valor)
    {
        base.Sacar(valor + TaxaManutencao);
    }

    public override void Depositar(double valor)
    {
        if (valor >= 0)
        {
            this.Saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Valor inválido!");
        }
    }

}

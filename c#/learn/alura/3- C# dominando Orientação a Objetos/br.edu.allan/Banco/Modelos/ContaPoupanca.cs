namespace Banco.Modelos;

public class ContaPoupanca : Conta
{

    public override void Sacar(double valor)
    {
        if (valor >= 0)
        {
            if (valor <= Saldo)
            {
                this.Saldo = valor - Saldo;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        else
        {
            Console.WriteLine("Valor inválido!");
        }
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

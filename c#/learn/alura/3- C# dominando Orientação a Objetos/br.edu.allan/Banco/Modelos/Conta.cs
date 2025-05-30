namespace Banco.Modelos;

internal class Conta
{

    public double Saldo { get; set; }

    public virtual void Sacar(double valor)
    {
        if (valor >= 0)
        {
            if (valor <= Saldo)
            {
                this.Saldo -= valor;
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

    public virtual void Depositar(double valor)
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
    public virtual double CalcularSaldo()
    {
        return Saldo;
    }



}

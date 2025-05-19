
public class Account
{

    public string Agencia { get; set; }
    public int NumeroIndicador { get; set; }
    public Titular Titular { get; set; }
    public float Saldo { get; set; }
    public string Senha { get; set; }
    public double Limite { get; set; }

    public string Informacoes => $"Conta nº {this.NumeroIndicador}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";

    public Account()
    {
        this.Titular = new Titular();
    }

    public Account(Titular titular, string agencia, int numeroIndicador, double limite)
    {
        this.Titular = titular;
        this.Agencia = agencia;
        this.NumeroIndicador = numeroIndicador;
        this.Limite = limite;
        this.Saldo = 0;
    }

    public void ExibirDadosConta()
    {

        Console.WriteLine("DADOS DA CONTA:");

        Console.WriteLine($"Número Indicador: {NumeroIndicador}");
        Console.WriteLine($"Titular: {Titular.Nome}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Senha: {Senha}");
    }


}

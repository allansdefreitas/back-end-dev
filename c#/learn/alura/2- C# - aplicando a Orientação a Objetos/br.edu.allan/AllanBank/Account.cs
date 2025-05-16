
public class Account
{

    public string Agencia { get; set; }
    public int NumeroIndicador { get; set; }
    public Titular Titular { get; set; }
    public float Saldo { get; set; }
    public string Senha { get; set; }

    public Account()
    {
        this.Titular = new Titular();
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

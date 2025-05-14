
public class Account
{

    public int numeroIndicador;
    public string titular;
    public float saldo;
    public string senha;

    public void ExibirDadosConta(){

        Console.WriteLine("DADOS DA CONTA:");

        Console.WriteLine($"Número Indicador: {numeroIndicador}");
        Console.WriteLine($"Título: {titular}");
        Console.WriteLine($"Saldo: {saldo}");
        Console.WriteLine($"Senha: {senha}");
    }

    
}


public class Account
{

    public int NumeroIndicador { get; set; }
    public string Titular {get; set; }  
    public float Saldo { get; set; }
    public string Senha { get; set; }

    public void ExibirDadosConta(){

        Console.WriteLine("DADOS DA CONTA:");

        Console.WriteLine($"Número Indicador: {NumeroIndicador}");
        Console.WriteLine($"Título: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Senha: {Senha}");
    }

    
}

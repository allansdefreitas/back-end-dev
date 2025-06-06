namespace Contato.Modelos;

public class SMS : INotificavel
{
    public string NumeroTelefone { get; set; }

    public void EnviarNotificacao()
    {
        Console.WriteLine($"Enviando SMS para {NumeroTelefone}: Notificação importante!");
    }
}
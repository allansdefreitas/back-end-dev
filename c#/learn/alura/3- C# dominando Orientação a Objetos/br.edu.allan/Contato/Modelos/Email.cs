namespace Contato.Modelos;

public class Email : INotificavel
{
    public string EnderecoEmail { get; set; }

    public void EnviarNotificacao()
    {
        Console.WriteLine($"Enviando e-mail para {EnderecoEmail}: Notificação importante!");
    }
}
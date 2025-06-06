using Contato.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {

        Email email = new Email();
        email.EnderecoEmail = "allan@email.com";

        email.EnviarNotificacao();

        SMS sms = new SMS();
        sms.NumeroTelefone = "5533344";

        sms.EnviarNotificacao();

    }
}
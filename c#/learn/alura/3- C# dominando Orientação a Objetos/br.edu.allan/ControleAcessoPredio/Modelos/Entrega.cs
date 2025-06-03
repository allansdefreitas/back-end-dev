namespace ControleAcessoPredio.Modelos;

internal class Entrega : IResumoAcesso
{
    public string Representante { get; }

    public Entrega(string representante)
    {
        Representante = representante;
    }


    public string Resumo => $"Entrega feita pelo representante {Representante}";
}



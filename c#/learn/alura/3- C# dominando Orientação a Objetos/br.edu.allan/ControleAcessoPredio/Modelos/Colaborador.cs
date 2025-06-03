
namespace ControleAcessoPredio.Modelos;

internal class Colaborador : IResumoAcesso
{
    public int IdAcesso { get; }

    public Colaborador(int idAcesso)
    {
        IdAcesso = idAcesso;
    }

    public string Resumo => $"Colaborador ID: {IdAcesso}";
}


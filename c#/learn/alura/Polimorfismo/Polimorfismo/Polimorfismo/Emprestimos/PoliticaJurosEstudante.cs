namespace Polimorfismo.Emprestimos;

public class PoliticaJurosEstudante : IPoliticaJuros
{
    public decimal Calcular(decimal valor, int meses)
    {
        return valor + (valor * 0.01m * meses);
    }
}
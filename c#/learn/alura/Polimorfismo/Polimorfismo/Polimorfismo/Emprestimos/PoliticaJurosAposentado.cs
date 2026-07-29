namespace Polimorfismo.Emprestimos;

public class PoliticaJurosAposentado : IPoliticaJuros
{
    public decimal Calcular(decimal valor, int meses)
    {
        return valor + (valor * 0.006m * meses);
    }
}
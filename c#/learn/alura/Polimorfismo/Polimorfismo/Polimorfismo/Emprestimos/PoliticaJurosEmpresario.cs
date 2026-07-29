namespace Polimorfismo.Emprestimos;

public class PoliticaJurosEmpresario : IPoliticaJuros
{
    public decimal Calcular(decimal valor, int meses)
    {
        return valor + (valor * 0.025m * meses);
    }
}
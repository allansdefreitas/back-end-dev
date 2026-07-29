namespace Polimorfismo.Emprestimos;

public class Emprestimo
{
    public decimal Valor { get; }
    public int Meses { get; }

    private readonly IPoliticaJuros _politica;

    public Emprestimo(decimal valor, int meses, IPoliticaJuros politica)
    {
        Valor = valor;
        Meses = meses;
        _politica = politica;
    }

    public decimal CalcularValorFinal()
    {
        return _politica.Calcular(Valor, Meses);
    }
}
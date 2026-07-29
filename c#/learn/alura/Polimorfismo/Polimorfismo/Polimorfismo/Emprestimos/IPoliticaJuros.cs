namespace Polimorfismo.Emprestimos;

public interface IPoliticaJuros
{
    decimal Calcular(decimal valor, int meses);
}
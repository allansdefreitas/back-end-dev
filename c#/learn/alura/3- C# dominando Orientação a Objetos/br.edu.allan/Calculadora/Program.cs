using Edu.Allan.Calculadora.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {


        Console.WriteLine(Calculadora.Somar(1, 10));

        Console.WriteLine(Calculadora.Subtrair(10, 9));

        Console.WriteLine(Calculadora.Multiplicar(10, 9));

        Console.WriteLine(Calculadora.Dividir(10, 2));

        Console.WriteLine(Calculadora.RaizQuadrada(144));

        Console.WriteLine(Calculadora.Potencia(10, 2));
    }
}
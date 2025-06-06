using GeometriaInterface.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Circulo  circulo = new Circulo();
        circulo.Raio = 2;

        Console.WriteLine(circulo.CalcularPerimetro());
        
        Retangulo retangulo = new Retangulo();
        retangulo.Largura = 2;
        retangulo.Comprimento = 3;

        Console.WriteLine(retangulo.CalcularPerimetro());

    }
}
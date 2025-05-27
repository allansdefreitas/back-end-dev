namespace Geometria.Modelos;

internal class Triangulo : FormaGeometrica
{

    public double Base { get; set; }
    public double Altura { get; set; }

    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }

    public override double CalcularPerimetro()
    {
        // Considerando um triângulo genérico
        return Base + Altura + Math.Sqrt(Base * Base + Altura * Altura);
    }
}

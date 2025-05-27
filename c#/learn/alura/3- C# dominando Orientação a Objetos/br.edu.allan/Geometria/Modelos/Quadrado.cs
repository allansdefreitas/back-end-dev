namespace Geometria.Modelos;

internal class Quadrado : FormaGeometrica
{
    public double Lado { get; set; }

    public override double CalcularArea() 
    {
        return Math.Pow(Lado, 2);
    }

    public override double CalcularPerimetro()
    {
        return Lado * 4;
    }
}

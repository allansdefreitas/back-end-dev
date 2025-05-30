using Eletronicos.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        

        PianoDigital pianoDigital = new PianoDigital();

        pianoDigital.Modelo = "P 125";
        pianoDigital.Marca = "YAMAHA";
        pianoDigital.Preco = 3600;
        pianoDigital.QuantidadeTeclas = 88;

        Console.WriteLine(pianoDigital.ExibirInformacoes()); 
    }
}
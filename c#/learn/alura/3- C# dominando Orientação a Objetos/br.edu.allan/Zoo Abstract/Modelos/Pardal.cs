namespace Zoo_Abstract.Modelos;

internal class Pardal : Animal
{

    public override void Mover()
    {
        Console.WriteLine("Voando...");
    }

    public override void FazerSom()
    {
        Console.WriteLine("Eu não sei cantar...ainda ;)");
    }
}

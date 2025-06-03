namespace ScreenSoundObj.Modelos;

internal class Avaliacao
{
    public int Nota { get; }

    public Avaliacao(int nota)
    {
        if (nota < 0)
        {
            nota = 0;
        }else if (nota > 10)
        {
            nota = 10;
        }

        Nota = nota;
    }

    public static Avaliacao Parse(string textoNota)
    {
        int nota = int.Parse(textoNota);
        return new Avaliacao(nota);

    }


    // Somente para ver
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }

}
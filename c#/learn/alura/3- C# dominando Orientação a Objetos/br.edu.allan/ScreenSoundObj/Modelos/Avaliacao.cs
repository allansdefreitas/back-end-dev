namespace ScreenSoundObj.Modelos;

internal class Avaliacao
{
    public int Nota { get; }

    public Avaliacao(int nota)
    {
        Nota = nota;

    }

    public static Avaliacao Parse(string textoNota)
    {
        int nota = int.Parse(textoNota);
        return new Avaliacao(nota);

    }
}
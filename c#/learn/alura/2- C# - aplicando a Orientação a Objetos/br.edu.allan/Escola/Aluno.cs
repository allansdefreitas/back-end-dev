public class Aluno
{

    public string Nome { get; set; }
    private int idade;
    private List<float> notas { get; } = new List<float>();

    public int Idade
    {
        get => idade;
        set
        {
            if (value < 0)
                Console.WriteLine("Valor inválido para idade");
            else
                idade = value;
        }
    }

}
public class Pessoa
{
    public string Nome { get; set; }
    public Endereco Endereco { get; set; }

    public void ExibirInformacoes()
    {
        // Essa questão de usar propriedade da classe (aqui, Endereco) com PascalCase confunde-a com um atributo estático de uma classe (em Java)
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Endereço: {Endereco.Rua}, {Endereco.Cidade}, {Endereco.Estado}");
    }
}
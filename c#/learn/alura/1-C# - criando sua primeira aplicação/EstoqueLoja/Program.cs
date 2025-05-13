// See https://aka.ms/new-console-template for more information

Console.Clear();
Console.WriteLine("Sistema de controle de estoque");

Dictionary<string, int> produtosQuantidades = new Dictionary<string, int> {
    {"Máquina de lavar louça 14 serviços", 1},
    {"Freezer vertical", 1},
    {"Sugar", 1},
    {"Ar condicionado", 1},
    {"Fogão 6 bocas", 1},
    {"Air Fryer", 1},
    {"Micro Ondas", 1},
    {"Estante de livros", 2}
};


Console.Write("Digite o nome do produto: ");
string nomeProduto = Console.ReadLine()!;

if (produtosQuantidades.Keys.Contains(nomeProduto))
{
    int quantidade = produtosQuantidades[nomeProduto]!;
    Console.WriteLine($"Quantidade: {quantidade}");
}
else
{
    Console.WriteLine("O produto não existe!");
}



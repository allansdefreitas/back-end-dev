using System;

class Hello
{
    static void Main()
    {
        // This line prints "Hello, World" 
        Console.WriteLine("Hello, World");

        Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
            { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
            { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
            { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
            { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
            { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
        };

        Console.Write("Digite o nome do veículo: ");
        string nomeVeiculo = Console.ReadLine()!;

        if(vendasCarros.Keys.Contains(nomeVeiculo)){

            List<int> quantidadesVendas = vendasCarros[nomeVeiculo];
            double mediaVendas = quantidadesVendas.Average();

            Console.WriteLine($"A média de venda do veículo {nomeVeiculo} é {mediaVendas}");

        }else{
            Console.WriteLine("O veículo não está cadastrado");
        }

    }
}

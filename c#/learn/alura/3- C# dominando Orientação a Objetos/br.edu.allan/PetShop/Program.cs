using PetShop.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Medico medicoEduardo = new("Dr. Eduardo");

        Dono donoAllan = new Dono("Allan");
        
        Pet bob = new Pet("Bob", "Fila");
        Pet tobby = new Pet("Tobby", "Caramelo");

        donoAllan.AdotarPet(tobby);
        donoAllan.AdotarPet(bob);

        DateTime dataConsulta = new DateTime(2025, 5, 20);
        Consulta consultaTobby = new(dataConsulta, medicoEduardo, donoAllan, tobby);
        medicoEduardo.RealizarConsulta(consultaTobby);
        consultaTobby.AdicionarDiagnostico(@"O pet está com sinais de febre");

        medicoEduardo.ExibirHistoricoConsultas();
        Console.WriteLine();
        donoAllan.ExibirPets();

        Produto shampooCanino = new Produto()
        {
            Nome = "Shampoo Clean Dog",
            PrecoUnitario = 25.90m,
            Quantidade = 10
        };

        Console.WriteLine(shampooCanino.CalcularPagamento()); 

    }
}
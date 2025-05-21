using OficinaAuto.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {

        Proprietario proprietarioAllan = new Proprietario("Allan");
        Veiculo veiculoEtios = new Veiculo("Toyota", "Etios Sedan", 2024, proprietarioAllan);
        Veiculo veiculoCorolla = new Veiculo("Toyota", "Corolla", 2025, proprietarioAllan);
        Veiculo veiculoYaris = new Veiculo("Toyota", "Yaris Sedan", 2025, proprietarioAllan);

        proprietarioAllan.ExibirVeiculos();
       

    }
}
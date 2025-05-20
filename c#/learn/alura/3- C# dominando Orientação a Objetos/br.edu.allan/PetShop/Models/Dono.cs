
namespace PetShop.Models;

internal class Dono
{


    public string Nome { get; set; }
    private List<Pet> _pets;


    public Dono() { 
        _pets = new List<Pet>();
    }

    public Dono(string nome)
    {
        Nome = nome;
        _pets = new List<Pet>();
    }

    public void AdotarPet(Pet pet)
    {
        _pets.Add(pet);
        pet.AdicionarDono(this);
    }

    public void ExibirPets()
    {
        Console.WriteLine($"\nPets de {this.Nome}:");
        for (int i=0; i < _pets.Count; i++)
        {
            Pet pet = _pets[i];
            Console.WriteLine($"{i+1}. {pet.Nome} - {pet.Raca}");
        }

        Console.WriteLine($"Total de {_pets.Count} pets\n");
    }

}

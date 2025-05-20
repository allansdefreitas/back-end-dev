namespace PetShop.Models;

internal class Pet
{


    public string Nome { get; }
    private Dono _dono;

    public string Raca { get; set; }


    public Pet(string nome)
    {
        Nome = nome;
    }
    public Pet(string nome, string raca)
    {
        Nome = nome;
        Raca = raca;
    }

    public void AdicionarDono(Dono dono)
    {
        _dono = dono;
    }

}

namespace PetShop.Models;

internal class Consulta
{

    public DateTime Data { get; }
    private Medico _medico;
    public Dono Dono { get; }
    public Pet Pet { get; }
    private string _diagnostico { get; set; }   
    public string Diagnostico => _diagnostico;

    public Consulta(DateTime data, Medico medico, Dono dono, Pet pet)
    {
        Data = data;
        Dono = dono;
        Pet = pet;
        _medico = medico;
    }
    public void AdicionarDiagnostico(string diagnostico)
    {
        _diagnostico = diagnostico;
    }


}

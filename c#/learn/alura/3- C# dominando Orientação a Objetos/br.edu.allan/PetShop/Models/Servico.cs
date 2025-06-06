namespace PetShop.Models;
public class Servico : IPagavel
{
    public string Nome { get; set; }
    public decimal TaxaHoraria { get; set; }
    public int HorasTrabalhadas { get; set; }

    public decimal CalcularPagamento()
    {
        return TaxaHoraria * HorasTrabalhadas;
    }
}
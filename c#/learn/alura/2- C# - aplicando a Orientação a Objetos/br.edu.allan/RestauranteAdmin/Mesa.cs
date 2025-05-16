public class Mesa
{
    public int Numero { get; set; }

    private bool estaOcupada;
    private bool estaReservada;

    public Mesa()
    {
        // Só por questão de clareza, pois o valor padrão de variável bool em classe já é false
        this.estaOcupada = false;
        this.estaReservada = false;
    }

    public int capacidadePessoas { get; set; }

    public void Ocupar()
    {
        this.estaOcupada = true;
    }

    public void Liberar()
    {
        this.estaOcupada = false;
    }

    public void Reservar()
    {
        this.estaReservada = true;
    }
    public void CancelarReserva()
    {
        this.estaReservada = false;
    }
}
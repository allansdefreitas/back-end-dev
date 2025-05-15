class Car
{
    public string Fabricante { get; set; }
    public string Modelo { get; set; }

    private int ano; // Um atributo privado
    public int QuantidadePortas { get; set; }

    // Propriedade somente leitura. Expressão de propriedade
    public string DescricaoDetalhada => $"Modelo do carro: {this.Fabricante} {this.Modelo} {this.Ano}";
    
    public int Ano
    {
        get => ano;
        set
        {

            System.Console.WriteLine(value);
            if (value >= 1960 && value <= 2023)
            {
                ano = value;
            }else
            {
                Console.WriteLine("Valor inválido! Insira um valor entre 1960 e 2023 (inclusive)");
            }
            
        }


    }
}
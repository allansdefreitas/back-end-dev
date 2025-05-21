namespace OficinaAuto.Modelos
{
    public class Proprietario
    {

        public string Nome { get;}

        private List<Veiculo> _veiculos;

        internal List<Veiculo> Veiculos {
            get{
                return _veiculos;
            }
        }

        public Proprietario(string nome)
        {
            Nome = nome;
            _veiculos = new List<Veiculo>();

        }

        public void ExibirVeiculos()
        {
            Console.WriteLine($"\nVeículos de {this.Nome}:\n");
            foreach(var veiculo in _veiculos)
            {
                Console.WriteLine($"{veiculo.Modelo} ({veiculo.Marca}) {veiculo.Ano}");
            }
        }

        internal void AdquirirVeiculo(Veiculo veiculo)
        {
            _veiculos.Add(veiculo);
        }
    }
}
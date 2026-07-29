using Polimorfismo.Emprestimos;
using Polimorfismo.GaleriaOnline;
using Polimorfismo.Reservas;
using Polimorfismo.Tarefa;

namespace Polimorfismo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // TarefaAgendada -------------------------------

            /*
            List<TarefaAgendada> tarefas = new List<TarefaAgendada>()
            {
                new BackupTarefa(),
                new LimpezaTarefa(),
                new RelatorioTarefa()
            };

            foreach (var tarefa in tarefas)
            {
                tarefa.Executar();
            }
            */

            // GaleriaOnline -------------------------------

            /*
            List<Media> medias = new List<Media>();
            medias.Add(new Image("foto_casamento.jpg", "1920 x1950"));
            medias.Add(new Video("video_casamento.mp4", "35 minutos"));

            foreach(var media in medias)
            {
                media.ShowDetails();
            }
            */

            // Reservas -------------------------------------

            /*
            List<Booking> bookings = new List<Booking>()
            {
                new VirtualBooking("Conferência de Canto Descomplicando a Música", "https://www.descomplicandoamusica.com"),
                new InPersonBooking("Winter Conference on Applications of Computer Vision", "Orlando, FL")
            };

            foreach(Booking booking in bookings)
            {
                booking.Show();
            }
            */

            PoliticaJurosEstudante politicaJurosEstudante = new PoliticaJurosEstudante();

            Emprestimo emprestimo = new Emprestimo(120000, 72, politicaJurosEstudante);


            Console.WriteLine(emprestimo.CalcularValorFinal());


        }
    }
}
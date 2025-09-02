using ScreenSound.Banco;
using ScreenSound.Menus;
using ScreenSound.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        ScreenSoundContext context = new ScreenSoundContext();
        DAL<Artist> artistDAL = new DAL<Artist>(context);
        DAL<Song> songDAL = new DAL<Song>(context);

        //Song song = new Song("Juízo Final");
        //SongDAL.Add(song);

        //song.Id = 1;
        //song.Name = "Sempre Alerta";
        //SongDAL.Update(song);

        //song.Id = 4;
        //song.Name = "O Senhor Pelejará por Nós";
        //SongDAL.Update(song);


        //song.Id = 3;
        //SongDAL.Delete(song.Id);

        //var songs = SongDAL.ListAll();

        //foreach (var ithSong in songs)
        //{
        //    Console.WriteLine(ithSong);
        //}
        //return;

        //var context = new ScreenSoundContext();
        //var artistDAL = new ArtistDAL(context);


        //var maraLima = new Artist("Mara Lima", "Cantora de música evangélica desde os anos 80.")
        //{
        //    Id = 1009
        //};

        //artistDAL.Add(maraLima);

        //maraLima.Bio = "Cantora de música cristã evangélica desde os anos 80. Conhecida por suas canções marcantes" +
        //    "ao longo da carreira, como, \"Daniel\", " +
        //    "\"Heroi sem Medalha\", \"Cavaleiro da Paz\", dentre outras.";

        //artistDAL.Update(maraLima);

        //artistDAL.Delete(maraLima);

        //artistDAL.PrintAll();


        //Artist ozeiasDePaula = new Artist("Ozéias de Paula", "Cantor de música evangélica desde os anos 70.");

        //ArtistDAL.Add(ozeiasDePaula);
        //Artist victorinoSilva = new Artist("Victorino Silva", "É um cantor de música evangélica em atividade desde os anos 70. Muito" +
        //    "conhecido por suas canções como \"Meu Tributo\", \"És\", \"Vale à Pena Viver\", dentre outras, bastante renomadas.");

        //ArtistDAL.Add(victorinoSilva);

        //victorinoSilva.Bio += "É reconhecido por seu estilo peculiar de canto, algumas canções com a presença de orquestras e potência vocal," +
        //    "mesmo com idade avançada.";

        //victorinoSilva.Bio += "(...)";

        //victorinoSilva.Id = 1003;
        //ArtistDAL.Update(victorinoSilva);

        //ArtistDAL.Delete(1005); //Ozéias de Paula
        //ArtistDAL.Delete(1006); //Ozéias de Paula
        //ArtistDAL.Delete(1007); //Ozéias de Paula

        //var artists = ArtistDAL.ListAll();

        //foreach (var artist in artists)
        //{
        //    Console.WriteLine(artist);
        //}


        //return;

        //Artist ozeiasDePaula = new Artist("Ozéias de Paula", "Cantor de música evangélica desde os anos 70.");
        //Artist victorinoSilva = new Artist("Victorino Silva", "É um cantor de música evangélica em atividade desde os anos 70. Muito" +
        //    "conhecido por suas canções como \"Meu Tributo\", \"És\", \"Vale à Pena Viver\", dentre outras, bastante renomadas.");

        //var maraLima = new Artist(
        //    "Mara Lima",
        //    "Cantora de música cristã evangélica desde os anos 80. Conhecida por suas canções marcantes ao longo da carreira, como \"Daniel\", \"Heroi sem Medalha\", \"Cavaleiro da Paz\", dentre outras."
        //);

        //artistDAL.Add(ozeiasDePaula);
        //artistDAL.Add(victorinoSilva);
        //artistDAL.Add(maraLima);

        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new MenuRegistrarArtista());
        opcoes.Add(2, new MenuRegistrarMusica());
        opcoes.Add(3, new MenuMostrarArtistas());
        opcoes.Add(4, new MenuMostrarMusicas());
        opcoes.Add(-1, new MenuSair());

        void ExibirLogo()
        {
            Console.WriteLine(@"

            ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
            ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
            ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
            ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
            ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
            ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
            ");
            Console.WriteLine("Boas vindas ao Screen Sound 3.0!");
        }

        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar um artista");
            Console.WriteLine("Digite 2 para registrar a música de um artista");
            Console.WriteLine("Digite 3 para mostrar todos os artistas");
            Console.WriteLine("Digite 4 para exibir todas as músicas de um artista");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
            {
                Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];

                menuASerExibido.Executar(artistDAL);
                if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }

        ExibirOpcoesDoMenu();
    }
}
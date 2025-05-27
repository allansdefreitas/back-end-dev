using ScreenSoundObj.Menus;
using ScreenSoundObj.Modelos;

internal class Program
{
    private static void RegistrarBandasIniciais(Dictionary<string, Banda> bandasRegistradas)
    {
        Banda bandaJacira = new("Jacira");
        Avaliacao avaliacao = new(-1);
        bandaJacira.AdicionarNota(avaliacao);
        bandaJacira.AdicionarNota(new Avaliacao(11));
        bandaJacira.AdicionarNota(new Avaliacao(9));

        Banda bandaVictorinoSilva = new Banda("Victorino Silva");
        bandaVictorinoSilva.AdicionarNota(new Avaliacao(10));
        bandaVictorinoSilva.AdicionarNota(new Avaliacao(10));
        bandaVictorinoSilva.AdicionarNota(new Avaliacao(9));

        bandasRegistradas.Add(bandaJacira.Nome, bandaJacira);
        bandasRegistradas.Add(bandaVictorinoSilva.Nome, bandaVictorinoSilva);

    }
    private static void Main(string[] args)
    {
        Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, Banda>();
        RegistrarBandasIniciais(bandasRegistradas);
              
        void ExibirMenu()
        {
            Menu.ExibirLogo();
            Menu.ExibirOpcoesDoMenu();
            int opcao = Menu.ObterOpcaoUsuario();

            switch (opcao)
            {
                case 1:
                    MenuRegistroBanda menuRegistroBanda = new();
                    menuRegistroBanda.Executar(bandasRegistradas);
                    ExibirMenu();
                    break;
                case 2:
                    MenuRegistroAlbum menuRegistroAlbum = new();
                    menuRegistroAlbum.Executar(bandasRegistradas);
                    ExibirMenu();
                    break;
                case 3:
                    MenuExibicaoBanda menuExibicaoBanda = new();
                    menuExibicaoBanda.Executar(bandasRegistradas);
                    ExibirMenu();
                    break;
                case 4:
                    MenuAvaliacaoBanda menuAvaliacaoBanda = new();
                    menuAvaliacaoBanda.Executar(bandasRegistradas);
                    ExibirMenu();
                    break;
                case 5:
                    MenuExibicaoDetalhes menuExibicaoDetalhes = new MenuExibicaoDetalhes();
                    menuExibicaoDetalhes.Executar(bandasRegistradas);
                    ExibirMenu();
                    break;
                case -1:
                    Console.WriteLine("Tchau tchau :)");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
 
        ExibirMenu();
    }
}
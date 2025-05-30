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
        Dictionary<int, Menu> opcoes = new();

        opcoes.Add(1, new MenuRegistroBanda());
        opcoes.Add(2, new MenuRegistroAlbum());
        opcoes.Add(3, new MenuExibicaoBanda());
        opcoes.Add(4, new MenuExibicaoBanda());
        opcoes.Add(5, new MenuExibicaoDetalhes());
        opcoes.Add(-1, new MenuSaida());

        RegistrarBandasIniciais(bandasRegistradas);
  
        Menu.ExibirLogo();
        Menu.ExibirOpcoesDoMenu();
        int opcao = Menu.ObterOpcaoUsuario();



        if (opcoes.ContainsKey(opcao))
        {
            Menu menuASerEscolhido = opcoes[opcao];
            menuASerEscolhido.Executar(bandasRegistradas);
            if (opcao > 0) Menu.ExibirOpcoesDoMenu();
        }else
        {
            Console.WriteLine("Opção inválida");
        }
    }
}
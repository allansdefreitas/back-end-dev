using Edu.Allan.ScreenSoundObj.Modelos;
using ScreenSoundObj.Modelos;


namespace ScreenSoundObj.Menus;

internal class MenuAvaliacaoBanda : Menu
{

    public void Executar(Dictionary<string, Banda> bandasRegistradas) {
        Console.Clear();
        MenuExibicaoDetalhes menu = new MenuExibicaoDetalhes();
        menu.ExibirTituloDaOpcao("Avaliar banda");

        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda bandaAvaliada = bandasRegistradas[nomeDaBanda];

            Console.Write($"Qual a nota que a banda {bandaAvaliada.Nome} merece: ");
            string notaString = Console.ReadLine()!;

            Avaliacao avaliacao = Avaliacao.Parse(notaString);
            bandaAvaliada.AdicionarNota(avaliacao);

            Console.WriteLine($"\nA nota {avaliacao.Nota} foi registrada com sucesso para a banda {bandaAvaliada.Nome}");
            Thread.Sleep(2000);
            Console.Clear();
            
            
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            
        }

    }
}


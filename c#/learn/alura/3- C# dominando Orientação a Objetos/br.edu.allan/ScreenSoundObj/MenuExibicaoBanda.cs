using ScreenSoundObj.Menus;
using ScreenSoundObj.Modelos;

internal class MenuExibicaoBanda
{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();

        MenuExibicaoDetalhes menu = new MenuExibicaoDetalhes();
        menu.ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        
    }
}
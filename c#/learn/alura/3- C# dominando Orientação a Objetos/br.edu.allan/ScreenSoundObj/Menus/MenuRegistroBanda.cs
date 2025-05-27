using ScreenSoundObj.Menus;
using ScreenSoundObj.Modelos;

internal class MenuRegistroBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        MenuExibicaoDetalhes menu = new MenuExibicaoDetalhes();
        menu.ExibirTituloDaOpcao("Registro das bandas");

        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;

        Banda bandaCriada = new Banda(nomeDaBanda);
        bandasRegistradas.Add(bandaCriada.Nome, bandaCriada);

        Console.WriteLine($"A banda {bandaCriada.Nome} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}
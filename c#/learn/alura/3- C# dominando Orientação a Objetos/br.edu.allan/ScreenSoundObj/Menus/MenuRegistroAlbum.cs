using ScreenSoundObj.Menus;
using ScreenSoundObj.Modelos;

internal class MenuRegistroAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        MenuExibicaoDetalhes menu = new MenuExibicaoDetalhes();
        menu.ExibirTituloDaOpcao("Registro de álbuns");

        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {

            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            Album album = new Album(tituloAlbum);
            banda.AdicionarAlbum(album);

            Console.WriteLine($"O álbum {album.Nome} de {banda.Nome} foi registrado com sucesso!");
            Thread.Sleep(4000);
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
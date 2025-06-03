
using ScreenSoundObj.Modelos;

namespace ScreenSoundObj.Menus;

internal class MenuExibicaoDetalhes : Menu
{

    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("Exibir detalhes da banda");

        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Clear();

            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"Banda: {banda.Nome}");
            Console.WriteLine($"Média da Banda: {banda.Media.ToString("F2")}");
            Console.WriteLine($"A banda \"{nomeDaBanda}\" possui`{banda.Albuns.Count} álbuns\n");

            //Console.WriteLine($"\nA média da banda \"{nomeDaBanda}\" é {banda.Media.ToString("F2")}.");

            Console.WriteLine("Discografia:\n");
            for (int i = 0; i < banda.Albuns.Count; i++)
            {
                Album album = banda.Albuns[i];
                Console.WriteLine($"{i + 1}. \"{album.Nome}\"\nMédia:{album.Media.ToString("F2")}.\n");
            }

            //foreach(Album album in banda.Albuns)
            //{
            //    Console.WriteLine($"\nA média do álbum \"{album.Nome}\" é {album.Media.ToString("F2")}.");
            //}
       
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            
        }
        else
        {
            Console.WriteLine($"\nA banda \"{nomeDaBanda}\" não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}


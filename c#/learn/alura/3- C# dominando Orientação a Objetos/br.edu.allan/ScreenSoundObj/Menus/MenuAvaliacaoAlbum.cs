
using ScreenSoundObj.Modelos;

namespace ScreenSoundObj.Menus;

internal class MenuAvaliacaoAlbum : Menu
{

    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        MenuExibicaoDetalhes menu = new MenuExibicaoDetalhes();
        menu.ExibirTituloDaOpcao("Avaliar álbum");

        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda bandaAvaliada = bandasRegistradas[nomeDaBanda];

            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;


            //if (bandaAvaliada.Albuns.Contains(album)) // outra forma de verificar
            if(bandaAvaliada.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                // Oter o primeiro álbum que satisfaz a condição especificada.
                Album album = bandaAvaliada.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                
                Console.Write($"Qual a nota que o album {album.Nome} merece: ");
                string notaString = Console.ReadLine()!;
                Avaliacao avaliacao = Avaliacao.Parse(notaString);

                album.AdicionarNota(avaliacao);
                Console.WriteLine($"\nA nota {avaliacao.Nota} foi registrada com sucesso para o álbum {album.Nome}");
            }
            else
            {
                Console.WriteLine($"O  álbum \"{bandaAvaliada.Nome}\" não existe!");
            }
            
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

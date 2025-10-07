using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarMusicas : Menu
{
    public override void Executar(DAL<Artist> artistDAL)
    {
        base.Executar(artistDAL);
        ExibirTituloDaOpcao("Exibir detalhes do artista");
        Console.Write("Digite o nome do artista que deseja conhecer melhor: ");
        string artistName = Console.ReadLine()!;

        var artistFound = artistDAL.GetBy(a => a.Name.Equals(artistName));

        if (artistFound is not null)
        {
            Console.WriteLine("\nDiscografia:");
            artistFound.ShowDiscography();
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO artista {artistName} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

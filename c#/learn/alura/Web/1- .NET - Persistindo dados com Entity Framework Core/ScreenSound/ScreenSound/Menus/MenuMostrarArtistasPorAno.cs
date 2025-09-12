using ScreenSound.Banco;
using ScreenSound.Menus;
using ScreenSound.Modelos;

internal class MenuMostrarMusicasPorAno : Menu
{
    public void Executar(DAL<Artist> artistDAL)
    {
        base.Executar(artistDAL);
        ExibirTituloDaOpcao("Mostrar musicas por ano de lançamento");
        Console.Write("Digite o ano para consultar músicas: ");

        string anoLancamento = Console.ReadLine()!;
        var songDAL = new DAL<Song>(new ScreenSoundContext());

        var listaAnoLancamento = songDAL.ListBy(song => song.ReleaseYear == Convert.ToInt32(anoLancamento));

        if (listaAnoLancamento.Any())
        {
            Console.WriteLine($"\nMusicas do Ano {anoLancamento}:");
            foreach (var musica in listaAnoLancamento)
            {
                musica.ShowTechnicalSheet();
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO ano {anoLancamento} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
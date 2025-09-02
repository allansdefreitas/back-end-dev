using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarMusica : Menu
{
    public override void Executar(DAL<Artist> artistDAL)
    {
        base.Executar(artistDAL);
        ExibirTituloDaOpcao("Registro de músicas");
        Console.Write("Digite o artista cuja música deseja registrar: ");
        string artistName = Console.ReadLine()!;

        var artistFound = artistDAL.GetBy(a => a.Name.Equals(artistName));

        if (artistFound is not null)
        {
            Console.Write("Agora digite o título da música: ");
            string tituloDaMusica = Console.ReadLine()!;

            Console.Write("Digite o ano de lançamento: ");
            string releaseYear = Console.ReadLine()!;

            Song song = new Song(tituloDaMusica, Convert.ToInt32(releaseYear));
            artistFound.AddSong(song);

            artistDAL.Update(artistFound);

            Console.WriteLine($"A música {tituloDaMusica} de {artistName} foi registrada com sucesso!");
            Thread.Sleep(4000);
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

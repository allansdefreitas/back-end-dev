using ScreenSound.Shared.Modelos.Modelos;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScreenSound.Modelos;

[Table("Musicas")]
public class Song
{
    public int Id { get; set; }
    
    [Column("Nome")]
    public string Name { get; set; }

    public int? ReleaseYear { get; set; }
    public int? ArtistId { get; set; }

    public virtual Artist? Artist { get; set; }

    public virtual ICollection<Genre> Genres { get; set; }

    public Song()
    {
        Artist = new Artist();
    }

    public Song(string name)
    {
        Name = name;
        Artist = new Artist();
    }

    public Song(string name, int releaseYear)
    {
        Name = name;
        ReleaseYear = releaseYear;
        Artist = new Artist();
    }

    public void ShowTechnicalSheet()
    {
        Console.WriteLine($"Name: {Name}");
    }

    public override string ToString()
    {
        return @$"Id: {Id}
        Name: {Name}";
    }
}
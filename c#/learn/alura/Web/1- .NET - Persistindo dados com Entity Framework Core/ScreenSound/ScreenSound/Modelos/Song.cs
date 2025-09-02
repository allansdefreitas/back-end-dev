using System.ComponentModel.DataAnnotations.Schema;

namespace ScreenSound.Modelos;

[Table("Musicas")]
internal class Song
{
    public Song(string name)
    {
        Name = name;
    }

    [Column("Nome")]
    public string Name { get; set; }
    public int Id { get; set; }

    public int ReleaseYear { get; set; }

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
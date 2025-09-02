using System.ComponentModel.DataAnnotations.Schema;

namespace ScreenSound.Modelos;

[Table("Artistas")]
internal class Artist
{
    public ICollection<Song> Songs { get; set; } = new List<Song>();    

    public Artist(string name, string bio)
    {
        Name = name;
        Bio = bio;
        ProfilePicture = "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png";
    }

    [Column("Nome")]
    public string Name { get; set; }

    [Column("FotoPerfil")]
    public string ProfilePicture { get; set; }

    [Column("Bio")]
    public string Bio { get; set; }
    public int Id { get; set; }

    public void AddSong(Song song)
    {
        Songs.Add(song);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Discography of artist {Name}");
        foreach (var song in Songs)
        {
            Console.WriteLine($"Song: {song.Name}");
        }
    }

    public override string ToString()
    {
        return $@"Id: {Id}
            Name: {Name}
            Foto de Perfil: {ProfilePicture}
            Bio: {Bio}";
    }
}
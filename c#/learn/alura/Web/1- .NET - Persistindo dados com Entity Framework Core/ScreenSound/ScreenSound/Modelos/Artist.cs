namespace ScreenSound.Modelos; 

internal class Artist 
{
    private List<Song> songs = new List<Song>();

    public Artist(string name, string bio)
    {
        Name = name;
        Bio = bio;
        ProfilePicture = "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png";
    }

    public string Name { get; set; }
    public string ProfilePicture { get; set; }
    public string Bio { get; set; }
    public int Id { get; set; }

    public void AddSong(Song song)
    {
        songs.Add(song);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Discography of artist {Name}");
        foreach (var song in songs)
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
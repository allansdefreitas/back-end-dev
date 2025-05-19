public class Playlist
{

    public string Title { get; }
    private List<Song> songs { get; }


    public Playlist(string title)
    {
        Title = title;
        this.songs = new List<Song>();
    }

    public void AddSong(Song song)
    {
        this.songs.Add(song);
    }


    public void ShowPlayList()
    {
        Console.WriteLine($"{this.Title}");

        for (int i = 0; i < this.songs.Count; i++)
        {
            Song ithSong = songs[i];
            string songTitleAndArtist = $"{ithSong.Title} - {ithSong.Artist.Name}";

            Console.WriteLine($"{i + 1}. {songTitleAndArtist}");
        }
    }

}
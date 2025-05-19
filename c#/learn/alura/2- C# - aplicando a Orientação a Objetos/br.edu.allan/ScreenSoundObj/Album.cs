public class Album
{

    private List<Song> songs;
    public string Title { get; }
    public int ReleaseYear { get; set; }

    // Sum the total time of the songs 
    public int DurationInSeconds => this.songs.Sum(s => s.DurationInSeconds);

    public Album(string title)
    {
        this.Title = title;
    }

    public void AddSong(Song song)
    {
        this.songs = new List<Song>();
        this.songs.Add(song);
    }

    public void ShowAlbum()
    {
        Console.WriteLine($"Songs of album {this.Title} ({this.ReleaseYear})");

        // foreach (var song in this.songs)
        // {
        //     Console.WriteLine($"Song: {song.Title}");
        // }

        Console.WriteLine("ALBUM: {0}", this.Title.ToUpper());

        for (int i = 0; i < this.songs.Count; i++)
        {
            Song ithSong = songs[i];
            Console.WriteLine($"1. {ithSong.Title}");
        }
        float durationInMinutes = (float)(this.DurationInSeconds / 60);
        Console.WriteLine($"The album {this.Title} ({this.ReleaseYear}) - {durationInMinutes} min.");
    }


}
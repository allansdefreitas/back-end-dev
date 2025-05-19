public class Album
{

    public List<Song> Songs { get; }
    public string Title { get; }
    public int ReleaseYear { get; set; }

    // Sum the total time of the songs 
    // public int DurationInSeconds => this.songs.Sum(s => s.DurationInSeconds);
    public int DurationInSeconds
    {
        get =>
            this.Songs.Sum(s => s.DurationInSeconds);
        set
        {
            DurationInSeconds = value;
        }
    }

    public Album(string title)
    {
        this.Songs = new List<Song>();
        this.Title = title;
    }

    public void AddSong(Song song)
    {
        this.Songs.Add(song);
    }

    public void ShowAlbum()
    {
        float durationInMinutes = (float)(this.DurationInSeconds / 60);
        Console.WriteLine($"\"{this.Title}\" ({this.ReleaseYear}) - {durationInMinutes} min.");

        // foreach (var song in this.songs)
        // {
        //     Console.WriteLine($"Song: {song.Title}");
        // }

        // Console.WriteLine("ALBUM: {0}", this.Title.ToUpper());

        for (int i = 0; i < this.Songs.Count; i++)
        {
            Song ithSong = Songs[i];
            Console.WriteLine($"1. {ithSong.Title}");
        }
        // Console.WriteLine($"The album {this.Title} ({this.ReleaseYear}) - {durationInMinutes} min.");
    }


}
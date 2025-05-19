public class User
{

    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    private List<Song> playbackHistorySongs;
    private List<Playlist> playlists;

    public User(string name, string email)
    {
        this.Name = name;
        this.Email = email;
        this.playbackHistorySongs = new List<Song>();
        this.playlists = new List<Playlist>();
    }

    public void AddPlaylist(Playlist playlist)
    {
        this.playlists.Add(playlist);
    }

    public void AddToPlaybackHistory(Song song)
    {
        this.playbackHistorySongs.Add(song);
    }


    public void ShowPlaylists()
    {
        foreach (var playlist in this.playlists)
        {
            playlist.ShowPlayList();
        }
    }



}
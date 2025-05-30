public class Band
{
    public string Name { get; }

    private List<Album> albumns;


    public Band(string name)
    {
        this.Name = name;
        this.albumns = new List<Album>();
    }

    public void AddAlbum(Album album)
    {
        this.albumns.Add(album);

    }

    public void showDiscography()
    {
        Console.WriteLine($"Discography of the band \"{this.Name}\"");

        foreach (Album album in this.albumns)
        {
            float albumDurationInMinutes = (float)(album.DurationInSeconds / 60);

            Console.WriteLine($"Album: \"{album.Title}\" ({album.ReleaseYear}) - {albumDurationInMinutes} min.");
        }

    }
}
public class Song
{
    public string Title { get; set; } // This is a PROPERTY (Propriedade), pois define mecanismo de acesso e manipulação (get; set). Usa PascalCase
    public Band Artist { get; }

    public Genre Genre { get; set; }
    public int DurationInSeconds { get; set; }
    public bool IsAvailableInPlann { get; set; }

    public Song(Band artist, string title)
    {
        this.Title = title;
        this.Artist = artist;
    }


    private float ImdbRating; // This is a FIELD (Atributo). Usa camelCAse. Melhor ser privado

    // short version. read only. Called arrow function or Lambda in C#
    //public string SummarizedDescription => 
    //    $"The song \"{Title}\" belongs to the artist \"{Artist}\" and has a duration of about {Duration} minutes";

    public string SummarizedDescription
    {
        get
        {
            return $"The song \"{Title}\" belongs to the artist \"{Artist}\", has a gender of {Genre} and has a duration of about {DurationInSeconds} minutes";
        }
    }

    public void ShowTechnicalSheet()
    {

        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Duration: {DurationInSeconds}");
        Console.WriteLine($"Available in plan: {IsAvailableInPlann}");
    }

    public void ShowTitleAndArtist()
    {
        Console.WriteLine($"Title/Artist: {Title} - {Artist}");
    }



}


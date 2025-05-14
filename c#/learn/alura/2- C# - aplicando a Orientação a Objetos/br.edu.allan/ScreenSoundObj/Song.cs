class Song
{
    public string title {get; set;}
    public string artist {get; set;}
    public int duration {get; set;}
    public bool isAvailableInPlann {get; set;}

    public void ShowTechnicalSheet(){

        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Artist: {artist}");
        Console.WriteLine($"Duration: {duration}");
        Console.WriteLine($"Available in plan: {isAvailableInPlann}");
    }

    public void ShowTitleAndArtist()
    {
        Console.WriteLine($"Title/Artist: {title} - {artist}");
    }



}


class Song
{
    public string title;
    public string artist;
    public int duration;
    public bool isAvailableInPlann;


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


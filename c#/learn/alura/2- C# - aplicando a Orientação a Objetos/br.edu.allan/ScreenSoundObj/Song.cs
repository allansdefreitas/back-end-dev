class Song
{
    public string Title {get; set;}
    public string Artist {get; set;}
    public int Duration {get; set;}
    public bool IsAvailableInPlann {get; set;}
    public string SummarizedDescription { 
        
        get{
            return $"The song \"{Title}\" belongs to the artist \"{Artist}\" and has a duration of about {Duration} minutes";
        } 
    }

    public void ShowTechnicalSheet(){

        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Available in plan: {IsAvailableInPlann}");
    }

    public void ShowTitleAndArtist()
    {
        Console.WriteLine($"Title/Artist: {Title} - {Artist}");
    }



}


namespace ScreenSound.Modelos;

internal class Song
{
    public Song(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public int Id { get; set; }

    public void ShowTechnicalSheet()
    {
        Console.WriteLine($"Name: {Name}");
      
    }

    public override string ToString()
    {
        return @$"Id: {Id}
        Name: {Name}";
    }
}
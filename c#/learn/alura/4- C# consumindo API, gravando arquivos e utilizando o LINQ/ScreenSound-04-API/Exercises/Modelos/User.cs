namespace Exercises.Modelos;

public class User
{

    public string Name {get; set;}

    public string Email { get; set; }

    public int Age { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"E-mail: {Email}");
        Console.WriteLine($"Age: {Age}\n");
    }

}

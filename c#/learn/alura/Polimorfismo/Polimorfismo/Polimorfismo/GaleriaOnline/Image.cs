namespace Polimorfismo.GaleriaOnline
{
    public class Image : Media
    {

        public string Resolution { get; set; }

        public Image(string name, string resolution)
        {
            Name = name;
            Resolution = resolution;
        }

        public override void ShowDetails(){

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Resolution: {Resolution}");
        }
    }
}

namespace Polimorfismo.GaleriaOnline
{
    public class Video : Media 
    {

        public string Duration { get; set; }

        public Video(string name, string duration)
        {
            Name = name;
            Duration = duration;
        }

        public override void ShowDetails(){
            Console.WriteLine($"Name: {Name}"); 
            Console.WriteLine($"Duration: {Duration}");
        }
    }
}

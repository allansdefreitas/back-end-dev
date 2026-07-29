namespace Polimorfismo.Reservas
{
    internal class InPersonBooking : Booking
    {
        public string Place { get; set; }

        public InPersonBooking(string theEvent, string place){
            Event = theEvent;
            Place = place;
        }

        public override void Show()
        {
            Console.WriteLine($"In Person Event: {Event}, Place: {Place}");
        }
    }
}

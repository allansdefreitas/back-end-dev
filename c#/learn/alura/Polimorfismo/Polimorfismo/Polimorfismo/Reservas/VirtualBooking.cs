using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Reservas
{
    internal class VirtualBooking : Booking
    {

        public string AccessLink;

        public VirtualBooking(string theEvent, string accessLink){

            Event = theEvent;
            AccessLink = accessLink;

        }

        public override void Show()
        {
            Console.WriteLine($"Virtual Event: {Event}, AccessLink: {AccessLink}");

        }
    }
}

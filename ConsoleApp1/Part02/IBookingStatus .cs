using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part02
{
    internal interface IBookingStatus
    {
        bool BookingStatus { get; }
        void Booking(Ticket t);
        void Cancellation(Ticket t);
    }
}

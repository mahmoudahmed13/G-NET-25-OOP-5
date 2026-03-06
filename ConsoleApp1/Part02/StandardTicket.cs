using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part02
{
    internal class StandardTicket : Ticket,IPrintable,ICloneable
    {
        public string SeatNumber { get; set; }
        public StandardTicket(string seatNumber, string movieName, decimal price) : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }
        //public override void PrintTicket()
        //{
        //    Console.WriteLine($"Ticket ID: {TicketId} - Movie Name: {MovieName}" +
        //    $" - Price: {Price} EGP - Price after tax: {PriceAfterTax} EGP - Seat: {SeatNumber}");
        //}

        public void Print()
        {
            Console.WriteLine($"Movie Name: {MovieName}" +
            $" - Price: {Price} EGP - Price after tax: {PriceAfterTax} EGP - Seat: {SeatNumber}");
        }

        public object Clone() => new StandardTicket(SeatNumber,MovieName,Price);
    }
}

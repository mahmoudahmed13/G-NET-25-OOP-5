using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part02
{
    internal class Ticket
    {
        private string _movieName;
        private decimal _price;
        public decimal PriceAfterTax => ((14 * _price) / 100) + _price;
        public int TicketId { get; }
        private static int ticketCounter = 0;
        public bool Status { get; set; }
        //public string BookingRef { get; set; }
        //=======================
        public string MovieName
        {
            get
            {
                return _movieName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 3)
                {
                    _movieName = value;
                    return;
                }
                Console.WriteLine("MovieName : cannot be null or empty ");

            }
        }
        public decimal Price => _price;
        public Ticket(string movieName, decimal price)
        {
            ticketCounter++;
            TicketId = ticketCounter;
            _movieName = movieName;
            _price = price;
            //BookingRef = $"BK-{TicketId}";
        }
        public static int GetTotalTicketsSold() => ticketCounter;
        public void SetPrice(decimal price)
        {
            if (price <= 0)
            {
                Console.WriteLine("Price : must be greater than 0");
                return;
            }

            _price = price;
        }
        public void SetPrice(decimal price, decimal multiplier)
        {
            if (price <= 0)
            {
                Console.WriteLine("Price : must be greater than 0");
                return;
            }

            _price = price * multiplier;
        }

        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket ID: {TicketId} - Movie Name: {MovieName}" +
                $" - Price: {Price} EGP - Price after tax: {PriceAfterTax} EGP");
        }

    }
}

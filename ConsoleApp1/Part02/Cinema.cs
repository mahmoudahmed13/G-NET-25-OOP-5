using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part02
{
    internal class Cinema : IPrintable,IBookingStatus
    {
        public string CinemaName { get; set; }


        List<Ticket> _list = new List<Ticket>(20);

        public bool BookingStatus { get; set; }
        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
        }

        public Ticket this[int index]
        {
            get
            {
                if (index >= 0 && index < _list.Count())
                    return _list[index];
                return null;


            }
            set
            {
                if (index >= 0 && index < _list.Count())
                    _list[index] = value;
                return;
            }

        }
        public Ticket? this[string movie]
        {
            get
            {
                foreach (var ticket in _list)
                {
                    if (ticket.MovieName == movie)
                        return ticket;
                }
                return null;
            }
        }

        public void Booking(Ticket t)
        {
            
            foreach (var ticket in _list)
            {
                if (ticket.Equals(t))
                { 
                    BookingStatus = true;
                    Console.WriteLine("Trying to book an already-booked ticket fail.");
                    break;
                }
                BookingStatus = false;
            }

            if ( BookingStatus == false && _list.Count <= 20)
            {
                BookingStatus = true;
                t.Status = BookingStatus;
                _list.Add(t);
                return;
            }
            Console.WriteLine("Cinema Cannot add ticket – cinema is fully booked.");
        }

        public void Cancellation(Ticket t)
        {
            //BookingStatus = false;
            //string label = BookingStatus ? "yes" : "No";
            foreach (var ticket in _list)
            {
                if (ticket.Equals(t))
                {
                    ticket.PrintTicket();
                    BookingStatus = true;
                    t.Status = false;
                    break;
                }
            }
            if (!BookingStatus)
            {
                Console.WriteLine("Trying to cancel a non booked ticket - Cancel Fail.");
            }
            Console.WriteLine($"Booked : no");
        }

        public void Print()
        {
            Console.WriteLine("========== All Tickets ==========");
            for (int i = 0; i < _list.Count; i++)
            {
                _list[i].PrintTicket();
                string label = _list[i].Status ? "yes" : "no";
                Console.WriteLine($"Booked : {label}");
            }
        }

        public void OpenCinema()
        {
            Console.Write($"========= Cinema is opened ==========");
            Console.WriteLine("Projector Started");
        }
        public void CloseCinema()
        {
            Console.WriteLine($"========= Cinema is closed ==========");
            Console.WriteLine("Projector Closed");
        }
    }
}

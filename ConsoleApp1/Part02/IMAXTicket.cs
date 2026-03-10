using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part02
{
    internal class IMAXTicket : Ticket,IPrintable,ICloneable
    {
        private bool _is3D;

        public bool Is3D
        {
            get
            {
                if (_is3D == true)
                    SetPrice(Price + 30);
                return false;
            }
        }

        public IMAXTicket(bool is3D, string movieName, decimal price) : base(movieName, price)
        {
            _is3D = is3D;
        }

        //public override void PrintTicket()
        //{
        //    string label = Is3D ? "Yes" : "No";
        //    base.PrintTicket();
        //    Console.WriteLine($"IMAX 3D: {label}");
        //}

        public void Print()
        {
            string label = Is3D ? "Yes" : "No";
            Console.WriteLine($"Movie Name: {MovieName}" +
                $" - Price: {Price} EGP - Price after tax: {PriceAfterTax} EGP - IMAX 3D: {label}");
        }

        public object Clone() => new IMAXTicket(Is3D,MovieName,Price);
    }
}

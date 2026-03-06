using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part02
{
    internal class VIPTicket : Ticket,IPrintable,ICloneable
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50m;
        public VIPTicket(bool lounge, string movieName, decimal price) : base(movieName, price)
        {
            LoungeAccess = lounge;
        }
        //public override void PrintTicket()
        //{
        //    base.PrintTicket();
        //    Console.WriteLine($", Lounge: {LoungeAccess}, Service: {ServiceFee} EGP");
        //}

        public void Print()
        {
            Console.WriteLine($"Movie Name: {MovieName} - Price: {Price} EGP " +
            $"- Price after tax: {PriceAfterTax} EGP - Lounge: {LoungeAccess}, Service: {ServiceFee} EGP");
        }

        public object Clone() => new VIPTicket(LoungeAccess,MovieName,Price);
    }
}

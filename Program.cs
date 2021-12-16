using System;

namespace makeItWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int ChildTckts, AdultTckts, TotalTckts, TotalPrice;

            ChildTckts = 2;
            AdultTckts = 3;
            TotalTckts = ChildTckts + AdultTckts;

            int BaseTicketPrice = 10;

            TotalPrice = (AdultTckts * BaseTicketPrice);
            TotalPrice += (ChildTckts * (BaseTicketPrice -3));

            Console.Write(AdultTckts + " Adult tickets + " + ChildTckts + " Child Tickets = $" + TotalPrice);

            // Comments are the standard fare. You have this kind
            /* And this kind. */
            /*
                # This kind of comment does not work, though.
            */
        }
    }
}

using System;

namespace makeItWork
{
    // -----------------------------------------------------------------------
    // I'm creating this to test out the different code examples given in
    // Programming in the Key of C# by Charles Petzold
    // -----------------------------------------------------------------------
    class Program
    {
        static void Main(string[] args)
        {
//            Console.WriteLine("Hello World!");
/*
            int ChildTckts, AdultTckts, TotalTckts, TotalPrice;

            ChildTckts = 2;
            AdultTckts = 3;
            TotalTckts = ChildTckts + AdultTckts;

            int BaseTicketPrice = 10;

            TotalPrice = (AdultTckts * BaseTicketPrice);
            TotalPrice += (ChildTckts * (BaseTicketPrice -3));

            Console.Write(AdultTckts + " Adult tickets + " + ChildTckts + " Child Tickets = $" + TotalPrice);
*/
            // Comments are the standard fare. You have this kind
            /* And this kind. */
            /*
                # This kind of comment does not work, though.
            */

            // See how high C# can count to.
            // uint X = 2;

            // Console.WriteLine(X);
            // Console.WriteLine(checked(X *= X));
            // Console.WriteLine(checked(X *= X));
            // Console.WriteLine(checked(X *= X));
            // Console.WriteLine(checked(X *= X));
            // Console.WriteLine(checked(X *= X - 1));
            // Console.WriteLine(checked(X *= X));
            // Console.WriteLine(checked(X *= X));
            // Console.WriteLine(checked(X *= X));
            // Console.WriteLine(X *= X);
            // Console.WriteLine(X *= X);
            // Console.WriteLine(X *= X);
            // Console.WriteLine(X *= X);
            // Console.WriteLine(X *= X);
            // Console.WriteLine(X *= X);
            // Console.WriteLine(X *= X);
            // Console.WriteLine(X *= X);
            // Console.WriteLine(X *= X);

            // Let's see the top and bottom value for a signed integer
            // Console.WriteLine("Signed");
            // int Signed = 2147483647;
            // int SignedZero = 0;

            // Console.Write(Signed + " + 1 = ");
            // Console.WriteLine(Signed + 1);
            
            // Console.Write(SignedZero + " - 1 = ");
            // Console.WriteLine(SignedZero - 1);

            // Console.WriteLine();
            // Console.WriteLine("Unsigned");
            // uint Unsigned = 2147483647;
            // uint UnsignedZero = 0;

            // Console.Write(Unsigned + " + 1 = ");
            // Console.WriteLine(Unsigned +1 );

            // Console.Write(UnsignedZero + " - 1 = ");
            // Console.WriteLine(UnsignedZero - 1);

            // Console.WriteLine(Int64.MinValue);

            string Greeting = "Hello, World!";

            Console.Write(Greeting);
            Console.WriteLine(" = " + Greeting.Length + " Characters");
        }
    }
}

using System;

namespace Inheritance
{
    internal class ExpandRandom
    {
        static void Main(string[] args)
        {
            UdvidetRandom ur = new UdvidetRandom();
            Console.WriteLine(ur.NextBool());
            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        class UdvidetRandom : System.Random
        {
            public bool NextBool()
            {
                int tal = this.Next(1,1002);
                // save if else 
                bool res = tal < 501;
                Console.WriteLine(tal);
                return res;
            }
        }
    }

}

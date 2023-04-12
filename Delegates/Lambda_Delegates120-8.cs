using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Lambda_Delegates120_8
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5,1,51,7,1,56,36,5};
            Console.WriteLine("Own method");
            Console.WriteLine(a.FindIndex(FindValue));
            Console.WriteLine("Lambda expression");
            Console.WriteLine(a.FindIndex((i) => { return i == 51; })) ;
            Console.WriteLine("Lambda expression short version");
            Console.WriteLine(a.FindIndex(i => i ==51));

            Console.WriteLine("List of values by own method");
            a.ForEach(ListValue);
            Console.WriteLine("Lambda expression");
            a.ForEach((i) => { Console.WriteLine(i); });
            Console.WriteLine("Lambda expression short version");
            a.ForEach( i => Console.WriteLine(i) );

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static bool FindValue(int a)
        {
            return a == 51;
        }

        static void ListValue(int i)
        {
            Console.WriteLine(i);
        }
    }
}

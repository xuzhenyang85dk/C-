using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MinDelegate1(string a);
    internal class Delegates120_1
    {
        static void Main1(string[] args)
        {
            // new instance f1
            MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
            f1.Invoke("test");

            // new instance f2
            MinDelegate1 f2 = new MinDelegate1(MinSkrivTilConsole);
            f2("test");

            // new instance f3
            MinDelegate1 f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("test");

            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= Console.WriteLine;
            
            // Test it by call it again and expect to get null ref exception
            //f1.Invoke("test");
        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }
}

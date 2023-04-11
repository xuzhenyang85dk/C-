using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Exercise
    {
        static void Main(string[] args)
        {

            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };

            double sum = 0;

            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
                Console.WriteLine("månedsløn: " + månedsløn[i]);
            }

            double gns = sum / månedsløn.Length;
            Console.WriteLine($"Gennemsnit { gns.ToString("N2") }");
        }
    }
}

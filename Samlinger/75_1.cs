using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlinger
{
    internal class _75_1
    {
        static void Main(string[] args)
        {
            // List<>
            List<int> a = new List<int>();

            a.Add(1);
            a.Add(2);   
            a.Add(3);
            foreach (int i in a)
            {
                Console.WriteLine(a[i-1]);
            }

            // Stack<>

            Stack<DateTime> b = new Stack<DateTime>();
            b.Push(DateTime.Now);
            b.Push(DateTime.Now.AddDays(1));
            b.Push(DateTime.Now.AddHours(2));

            foreach (DateTime i in b)
            {
                Console.WriteLine(i);
            }

            // Dictionary<>

            Dictionary<int, string> c = new Dictionary<int, string>();
            c.Add(00000, "DDDD");
            c.Add(11111, "EEEEE");
            c.Add(22222, "DDDDEFFE");

            Console.WriteLine(c[11111]);
        }
    }
}

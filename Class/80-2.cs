using System;

namespace Class
{
    internal class _80_2
    {
        static void Main1(string[] args)
        {
            Terning t1 = new Terning(1);
            Console.WriteLine(t1.værdi);    // 1
            t1.Ryst();
            Console.WriteLine(t1.værdi);  // tilfældig værdi

            Terning t2 = new Terning(2); 
            Console.WriteLine(t2.værdi);    // 2
            t2.Ryst();
            Console.WriteLine(t2.værdi); // tilfældig værdi

            Terning t3 = new Terning(8);
        }
    }
}

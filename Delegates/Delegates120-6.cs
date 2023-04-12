using System;
using System.Collections.Generic;

namespace Delegates
{
    internal class Delegates120_6
    {
        static void Main1(string[] args)
        {
            List<int> a = new List<int>() { 5,1,51,7,1,56,36,5};
            Console.WriteLine(a.FindIndex(FindVærdi));

            Console.WriteLine();
            a.ForEach(ListVærdi);
        }
        static bool FindVærdi(int a)
        {
            return a == 51;
        }
        static void ListVærdi(int a)
        {
            Console.WriteLine(a);
        }
    }
}

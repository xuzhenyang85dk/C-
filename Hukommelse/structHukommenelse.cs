using System;

namespace Hukommelse
{
    internal class structHukommenelse
    {
        static void Main1(string[] args)
        {
            Person k1 = new Person();   // k1 = { id: 0 } i stack
            k1.Id = 1;                  // k1 = { id: 1 } i stack
            Person k2 = new Person();   // k1 = { id: 1 } i stack   k2 = { id: 0 } i stack
            k2.Id = 2;                  // k1 = { id: 1 } i stack   k2 = { id: 2 } i stack
            Console.WriteLine(k1.Id);
            Console.WriteLine(k2.Id);
            k1 = k2;                    // k1 = { id: 2 } i stack   k2 = { id: 2 } i stack
            Console.WriteLine(k1.Id);
            Console.WriteLine(k2.Id);
            k1.Id = 3;                  // k1 = { id: 3 } i stack   k2 = { id: 2 } i stack
            Console.WriteLine(k1.Id);
            Console.WriteLine(k2.Id);
        }

        struct Person
        {
            public int Id;
        }
    }
}
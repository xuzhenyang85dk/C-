namespace OpgVariabler
{
    internal class OpgVariabler
    {
        static void Main(string[] args)
        {
            // variable n
            int n = 10;
            Console.WriteLine($"new variable: n = {n}");

            // add 1
            n++;
            Console.WriteLine($"n + 1 = {n}");

            // minus 1 
            n--;
            Console.WriteLine($"n - 1 = {n}");

            // add 20 
            n += 20;
            Console.WriteLine($"n + 20 = {n}");

            // variable d
            double d = 12.5;
            Console.WriteLine($"new variable:d = {d}");

            // add 1
            d++;
            Console.WriteLine($"d + 1 = {d}");

            // minus 1
            d--;
            Console.WriteLine($"d - 1 = {d}");

            // multi 12
            d *=2;
            Console.WriteLine($"d * 2 = {d}");

        }
    }
}
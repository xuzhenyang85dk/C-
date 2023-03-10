namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddSum(100,200));
            Console.WriteLine(CalAreal(10));
            Console.WriteLine(CalAmount(100,.25));
            Console.WriteLine("Hej");
        }

        static int AddSum(int a, int b)
        {
            return a + b;
        }

        static double CalAreal(int radius)
        {
            return radius * radius * System.Math.PI;
        }

        static double CalAmount(double number, double momPct)
        {
            return number - (number *momPct);
        }

        static void printText(string txt)
        {
            Console.WriteLine(txt);
        }
    }
}
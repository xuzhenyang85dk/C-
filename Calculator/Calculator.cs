namespace Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =  new System.Globalization.CultureInfo("da-DK");
            Console.WriteLine("Indtast tal 1");
            string tal1 = Console.ReadLine();
            Console.WriteLine($"Du har indstatet talet {tal1}");

            Console.WriteLine("Indtast tal 2");
            string tal2 = Console.ReadLine();
            Console.WriteLine($"Du har indstatet talet {tal2}");

            double t1 = Convert.ToDouble(tal1);
            double t2 = Convert.ToDouble(tal2);

            double t3 = t1 + t2;
            string res = t3.ToString("N2");
            Console.WriteLine($"Sum: {res}");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
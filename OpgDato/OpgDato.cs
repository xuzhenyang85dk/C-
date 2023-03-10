namespace OpgDato
{
    internal class OpgDato
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("dk-DK");
            /*int a = 45465456;
            double b = 234589.34;

            Console.WriteLine(a.ToString("N2"));
            Console.WriteLine(b.ToString("C4"));

            System.DateTime dato = new System.DateTime(2022, 1, 1, 12, 54, 23);
            Console.WriteLine(dato);
            DateTime dato2 = DateTime.Now;
            Console.WriteLine(dato2);
            DateTime dato3 = dato2.AddDays(3);
            Console.WriteLine(dato3);
            */
            
            /*      
             Opg
             */
            DateTime d1 = DateTime.Now;
            Console.WriteLine($"Today = {d1}");
            d1 = d1.AddDays(10);
            Console.WriteLine($"Add 10 days = {d1}");
            d1 = d1.AddMinutes(20);
            Console.WriteLine($"Add 22 min = {d1}");
            d1 = d1.AddMonths(-1);
            Console.WriteLine($"Minus 1 month = {d1}");
            DateTime d2 = new System.DateTime(1985,12,08);
            DateTime d3 = new System.DateTime(2023,12,08);
            TimeSpan tp = d3 - d2;
            Console.WriteLine($"TimeSpan = {tp.TotalDays} days");
            

        }
    }
}
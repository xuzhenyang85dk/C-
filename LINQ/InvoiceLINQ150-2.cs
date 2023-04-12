using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class InvoiceLINQ150_2
    {
        static void Main(string[] args)
        {
            var fakturaer = Faktura.HentFakturaer();
            
            // show all invoices in the list
            fakturaer.ForEach(f => Console.WriteLine(f));

            // sort after customer
            Console.WriteLine();
            fakturaer.OrderBy(f => f.Kunde).ToList().ForEach(f => Console.WriteLine(f));

            // sort after date
            Console.WriteLine();
            fakturaer.OrderBy(f => f.Dato).ToList().ForEach(f => Console.WriteLine(f));

            // find all from Fyn  and sort after date
            Console.WriteLine();
            Console.WriteLine(fakturaer.Count(f => f.Region == "Fyn"));

            // sum of sales
            Console.WriteLine();
            Console.WriteLine(fakturaer.Sum(f => f.Salg).ToString("N2"));

            // sum sales from Fyn
            Console.WriteLine();
            Console.WriteLine(fakturaer.Where(i => i.Region == "Fyn").Sum(f => f.Salg).ToString("N2"));
        }
    }

    public class Faktura
    {
        public DateTime Dato { get; set; }
        public int Nummer { get; set; }
        public string Kunde { get; set; }
        public string Region { get; set; }
        public double Salg { get; set; }

        public static List<Faktura> HentFakturaer()
        {
            List<Faktura> lst = new List<Faktura>
            {
                new Faktura { Dato = new DateTime(2020, 7, 1), Nummer = 1, Kunde = "Jens", Region = "Fyn", Salg = 100 },
                new Faktura { Dato = new DateTime(2020, 5, 1), Nummer = 2, Kunde = "Anders", Region = "Fyn", Salg = 300 },
                new Faktura { Dato = new DateTime(2021, 1, 1), Nummer = 3, Kunde = "Mette", Region = "Sjælland", Salg = 150 },
                new Faktura { Dato = new DateTime(2020, 12, 1), Nummer = 4, Kunde = "Hans", Region = "Jylland", Salg = 900 },
            };
            return lst;
        }

        public override string ToString()
        {
            return $"{Dato.ToShortDateString()} {Nummer} {Kunde} {Region} {Salg}";
        }
    }
}

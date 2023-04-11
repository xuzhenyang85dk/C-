namespace Inheritance
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Person p = new Person() { Fornavn = "Xu Zhen", Efternavn = "Yang"};
            Console.WriteLine(p.FuldtNavn());
            Elev e = new Elev() { Fornavn = "Caroline", Efternavn = "Wang",Klasselokale = "Klasselokale1"};
            Console.WriteLine(e.NavnMedKlasse());
            Instruktør i = new Instruktør() { Fornavn = "Huafu", Efternavn = "Wang", NøgleId = 1 };
            Console.WriteLine(i.FuldtNavn());

        }

        class Person
        {
            public string Fornavn { get; set; }
            public string Efternavn { get; set; }

            public string FuldtNavn()
            {
                return Fornavn + " " + Efternavn;
            }

        }

        class Elev : Person
        {
            public string Klasselokale { get; set; }
            public string NavnMedKlasse()
            {
                return Fornavn + " " + Efternavn + " "+ Klasselokale;
            }
        }

        class Instruktør : Person
        {
            public int NøgleId { get; set; }
            public string FuldtNavn()
            {
                return Fornavn + " " + Efternavn + " " + NøgleId;
            }
        }
    }
}
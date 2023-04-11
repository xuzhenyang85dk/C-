using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDice
{
    internal class PersonMain
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Efternavn = "cronberg";
            p1.Fornavn = "mathias";
            p1.Fødselsår = 2006;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());


            Person p2 = new Person("mikkel", "cronberg", 2006);
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.EstimeretAlder());

            // Ekstra 
            // Til string
            string json = System.Text.Json.JsonSerializer.Serialize(p2);
            // Fra string
            Person p3 = System.Text.Json.JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(json);
        }
    }
}

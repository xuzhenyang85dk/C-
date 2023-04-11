using System;

namespace Indkapsling
{
    internal class DeserialiseringProperties
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Id = 1, Navn = "A", ErDansk = true, Dato =new DateTime(1966,01,01)};
            p1.SkrivPerson();
            Person p2 = new Person() { Id = 2, Navn = "B", ErDansk = true, Dato = new DateTime(2023, 01, 01) };
            p2.SkrivPerson();
            Person p3 = new Person() { Id = 3, Navn = "C", ErDansk = true, Dato = new DateTime(1988, 01, 01) };
            p2.SkrivPerson();

            string json = System.IO.File.ReadAllText(@"c:\Kursus\OpgVariabler\Indkapsling\data.json");
            List<Person> lst = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(json);

            foreach (var item in lst)
                Console.WriteLine(item.Navn);

            //// Bare for sjov - gem som xml
            //System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(List<Person>));
            //System.IO.TextWriter writer = new System.IO.StreamWriter(@"c:\Kursus\OpgVariabler\Indkapsling\data.xml");
            //x.Serialize(writer, lst);

            // Bare for sjov - brug ServiceStack.Text (NuGet) til at gemme som CSV            
            ServiceStack.Text.CsvConfig.ItemSeperatorString = ";";  // Dansk format
            System.IO.File.WriteAllText(@"c:\Kursus\OpgVariabler\Indkapsling\data.csv", ServiceStack.Text.CsvSerializer.SerializeToString(lst));
        }

        class Person
        {
            public int Id { get; set; }
            public string Navn { get; set; }
            public bool ErDansk { get; init; }

            public DateTime Dato { get; set; }

            public void SkrivPerson()
            {
                Console.WriteLine(Id + " " + Navn + " " + ErDansk + " " + Dato);
            }
        }
    }
}

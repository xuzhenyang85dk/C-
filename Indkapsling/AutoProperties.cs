using System;

namespace Indkapsling
{
    internal class AutoProperties
    {

        static void Mai3(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Xu Zhen";
            p.Efternavn = "Yang";
            Console.WriteLine(p.FuldtNavn());
        }
		class Person 
        {
            public string Fornavn { get; set; }
            private string efternavn;

            public string Efternavn
            {
                get { return efternavn; }
                set
                {
                    if (value.Length < 3)
                    {
                        efternavn = "";
                    }
                    else
                    {
                        efternavn = value;
                    }
                }
            }

            public string FuldtNavn()
            {
                return Fornavn + " " + Efternavn;
            }
        }
        

	}
}
